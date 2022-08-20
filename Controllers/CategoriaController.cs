using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NeighbodFood2.Models;
using NeighbodFood2.Servicios;

namespace NeighbodFood2.DTOs
{
    [Route("api/categorias")]
    [ApiController]
    [EnableCors("permitir")]
    public class CategoriaController : ControllerBase
    {
        private readonly NEIGHBORFOODContext context;
        private readonly IMapper mapper;
        private readonly IAlmacenadorArchivos almacenadorArchivos;
        private readonly string contenedor = "categorias";

        public CategoriaController(NEIGHBORFOODContext context, IMapper mapper, IAlmacenadorArchivos almacenadorArchivos)
        {
            this.context = context;
            this.mapper = mapper;
            this.almacenadorArchivos = almacenadorArchivos;

        }

        [HttpGet]
        public async Task<ActionResult<List<CategoriaDTO>>> TraerCategorias()
        {
            var categorias = await context.Categoria.ToListAsync();

            return mapper.Map<List<CategoriaDTO>>(categorias);
        }
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "Admin")]
        [HttpPost]
        public async Task<ActionResult> CrearCategoria([FromForm]CategoriaCreacionDTO categoriaCreacion)
        {
            var Categoria = await context.Categoria.Where(x => x.CategoriaNombre ==
                 categoriaCreacion.CategoriaNombre)
                .FirstOrDefaultAsync();

            if(Categoria != null)
            {
                return BadRequest($"La categoria {categoriaCreacion.CategoriaNombre} ya existe");
            }

            var categoria = mapper.Map<Categoria>(categoriaCreacion);

            if (categoriaCreacion.CategoriaImagen != null)
            {
                using var memoryStream = new MemoryStream();
                await categoriaCreacion.CategoriaImagen.CopyToAsync(memoryStream);
                var contenido = memoryStream.ToArray();
                var extension = Path.GetExtension(categoriaCreacion.CategoriaImagen.FileName);
                categoria.CategoriaImagen = await almacenadorArchivos.GuardarArchivo(contenido, extension, contenedor,
                    categoriaCreacion.CategoriaImagen.ContentType);
            }

           context.Add(categoria);
           await context.SaveChangesAsync();
           return Ok();
        }

        [HttpDelete("{id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "Admin")]
        public async Task<ActionResult> EliminarCategoria(int id)
        {
            var categoria = await context.Categoria.FindAsync(id);

            if(categoria == null)
            {
                return NotFound($"La categoria con el id {id} no existe");
            }

            var ruta = categoria.CategoriaImagen;
            await almacenadorArchivos.BorrarArchivo(ruta, contenedor); 

            context.Remove(categoria);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
