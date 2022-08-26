using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NeighbodFood2.DTOs;
using NeighbodFood2.Models;
using NeighbodFood2.Servicios;

namespace NeighbodFood2.Controllers
{
    [Route("api/platos")]
    [ApiController]
    [EnableCors("permitir")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "Admin")]
    public class PlatoController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly NEIGHBORFOODContext context;
        private readonly IAlmacenadorArchivos almacenadorArchivos;

        public PlatoController(IMapper mapper, NEIGHBORFOODContext context, IAlmacenadorArchivos almacenadorArchivos )
        {
            this.mapper = mapper;
            this.context = context;
            this.almacenadorArchivos = almacenadorArchivos;
        }


        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<List<PlatoDTO>>> TraerPlatos()
        {
            var platos = await context.Plato.ToListAsync();

            return mapper.Map<List<PlatoDTO>>(platos);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> RegistrarPlato(PlatoCreacionDTO platoCreacionDTO )
        {
            var plato = mapper.Map<Plato>(platoCreacionDTO);
            context.Add(plato);
            await context.SaveChangesAsync();
            return Created("se creo el plato", plato);
        }
    }
}
