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

    }
}
