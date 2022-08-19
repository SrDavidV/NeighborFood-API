using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NeighbodFood2.DTOs;
using NeighbodFood2.Models;
using NeighbodFood2.Servicios;

namespace NeighbodFood2.Controllers
{
    [Route("api/restaurantes")]
    [ApiController]
    [EnableCors("permitir")]
    public class RestauranteController : ControllerBase
    {
        private readonly NEIGHBORFOODContext context;
        private readonly IMapper mapper;
        private readonly IAlmacenadorArchivos almacenadorArchivos;
        private readonly string contenedor = "restaurantes";

        public RestauranteController(NEIGHBORFOODContext context, IMapper mapper,
            IAlmacenadorArchivos almacenadorArchivos
           )
        {
            this.context = context;
            this.mapper = mapper;
            this.almacenadorArchivos = almacenadorArchivos;
        }

        [HttpGet]
        public async Task<ActionResult<List<RestauranteDTO>>> TraerRestarurantes()
        {
            var Restaurantes = await context.Restaurante.ToListAsync();

            return mapper.Map<List<RestauranteDTO>>(Restaurantes);
        }

        [HttpPost]
        public async Task<ActionResult> RegistrarRestaurante([FromForm] RestauranteCreacionDTO restauranteCreacionDTO)
        {
            var entidad = mapper.Map<Restaurante>(restauranteCreacionDTO);

            if(restauranteCreacionDTO.RESTA_Imagen != null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await restauranteCreacionDTO.RESTA_Imagen.CopyToAsync(memoryStream);
                    var contenido = memoryStream.ToArray();
                    var extension = Path.GetExtension(restauranteCreacionDTO.RESTA_Imagen.FileName);
                    entidad.RESTA_Imagen = await almacenadorArchivos.GuardarArchivo(contenido, extension, contenedor,
                        restauranteCreacionDTO.RESTA_Imagen.ContentType);
                }
            }

            context.Add(entidad);
            await context.SaveChangesAsync();
            return NoContent();

        }

        [HttpPut("{id}")]
        public async Task<ActionResult>ModificarRestaurante(long id, [FromForm] RestauranteCreacionDTO restauranteCreacionDTO)
        {
            var restauranteDB = await context.Restaurante.FirstOrDefaultAsync(x => x.PK_RestauranteID == id);

            if (restauranteCreacionDTO == null)
            {
                return NotFound();
            }

            restauranteDB = mapper.Map(restauranteCreacionDTO, restauranteDB);

            if(restauranteCreacionDTO.RESTA_Imagen != null)
            {
                using(var memoryStream = new MemoryStream())
                {
                    await restauranteCreacionDTO.RESTA_Imagen.CopyToAsync(memoryStream);
                    var contenido = memoryStream.ToArray();
                    var extension = Path.GetExtension(restauranteCreacionDTO.RESTA_Imagen.FileName);
                    restauranteDB.RESTA_Imagen = await almacenadorArchivos.EditarArchivo(contenido, extension,
                        contenedor, restauranteDB.RESTA_Imagen, restauranteCreacionDTO.RESTA_Imagen.ContentType);
                }
            }

            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> BorrarRestaurante(long id)
        {
            var restaurante = await context.Restaurante.FindAsync(id);

            if(restaurante == null)
            {
                return NotFound($"El restaurante con el id {id} no existe");
            }

            var ruta = restaurante.RESTA_Imagen;
            await almacenadorArchivos.BorrarArchivo(ruta, contenedor);

            context.Remove(restaurante);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
