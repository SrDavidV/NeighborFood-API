using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NeighbodFood2.DTOs;
using NeighbodFood2.Models;

namespace NeighbodFood2.Controllers
{
    [Route("api/sedes")]
    [ApiController]
    [EnableCors("permitir")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "Admin")]
    public class SedeController : ControllerBase
    {
        private readonly NEIGHBORFOODContext context;
        private readonly IMapper mapper;
        public SedeController(NEIGHBORFOODContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<List<SedeDTO>>> TraerSedesRestaurantes(long id)
        {
            var sedeConsulta = await context.Restaurante.FindAsync(id);

            if (sedeConsulta == null)
            {
                return NotFound($"El restaurante con el id {id} no existe");
            }

            var sedes = await context.Sede.Where(x => x.FK_RestauranteID == id).ToListAsync();
            
            if(sedes.Count == 0)
            {
                return NoContent();
            }

            return mapper.Map<List<SedeDTO>>(sedes);
        }


        [HttpPost]
        public async Task<ActionResult> RegistrarSede(SedeCreacionDTO sedeCreacionDTO)
        {
            var sede = mapper.Map<Sede>(sedeCreacionDTO);
            context.Add(sede);
            await context.SaveChangesAsync();
            return Ok();    
        }
            
    }
}
