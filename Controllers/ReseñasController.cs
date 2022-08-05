using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NeighbodFood2.Models;
using Neighborfood.DTOs;


namespace Neighborfood.Controllers
{
    [Route("api/{restauranteId}/resenas")]
    [ApiController]
    [EnableCors("permitir")]
    public class ReseñasController : ControllerBase
    {

        private readonly NEIGHBORFOODContext context;
        private readonly IMapper mapper;
        private readonly UserManager<IdentityUser> userManager;
        public ReseñasController(NEIGHBORFOODContext context, IMapper mapper, UserManager<IdentityUser> userManager)
        {
            this.context = context;
            this.mapper = mapper;
            this.userManager = userManager;
        }

        [HttpGet(Name = "obtenerReseñasCliente")]
        public async Task<ActionResult<List<ReseñaDTO>>> ListarReseñas(long clienteId)
        {
            var exiteCliente = await context.Cliente.AnyAsync(x => x.PK_Cedula == clienteId);

            if (!exiteCliente)
            {
                return NotFound();
            }

            var reseñas = await context.Reseña.Where(x => x.FK_ClienteID == clienteId).ToListAsync();

            return mapper.Map<List<ReseñaDTO>>(reseñas);
        }

        [HttpPost]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult> CrearReseña(long restauranteId, ReseñaCreacionDTO reseñaCreacionDTO)
        {
            var emailClaim = HttpContext.User.Claims.Where(claim => claim.Type == "email").FirstOrDefault();
            var email = emailClaim.Value;
            var usuario = await userManager.FindByEmailAsync(email);
            var usuarioId = usuario.Id;

            var existeRestaurante = await context.Restaurante.AnyAsync(q => q.PK_RestauranteID == restauranteId);

            if (!existeRestaurante)
            {
                return NotFound($"El restaurante con el id {restauranteId} no existe");
            }

            var reseña = mapper.Map<Reseña>(reseñaCreacionDTO);
            reseña.UsuarioId = usuarioId;
            reseña.FK_RestauranteID = restauranteId;

            context.Add(reseña);
            await context.SaveChangesAsync();

            return NoContent();
        }
    }
}
