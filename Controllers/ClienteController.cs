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
    [Route("api/cliente")]
    [ApiController]
    [EnableCors("permitir")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ClienteController : ControllerBase
    {
        private readonly NEIGHBORFOODContext context;
        private readonly IMapper mapper;

        public ClienteController(NEIGHBORFOODContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<List<ClienteDTO>>> ListarCliente()
        {
            var listaClientes = await context.Cliente.ToListAsync();

            if (listaClientes.Count == 0)
            {
                return NotFound("No hay clientes registrados");
            }

            return mapper.Map<List<ClienteDTO>>(listaClientes);
        }

        [HttpGet]
        [Route("getclienteid/{id}")]
        public async Task<ActionResult<ClienteDTO>> TraerClientePorId(long id)
        {
            var consultaCliente = await context.Cliente.FindAsync(id);

            if (consultaCliente == null)
            {
                return NotFound($"El clienteDTO con el id {id} no se encontro");
            }

            return mapper.Map<ClienteDTO>(consultaCliente);
        }

        [HttpGet]
        [Route("getclientenombre/{nombre}")]
        public async Task<ActionResult<List<ClienteDTO>>> TraerClientesPorNombre([FromRoute] string nombre)
        {
            var clientes = await context.Cliente
                .Where(x => x.CLI_Nombre.Contains(nombre)).ToListAsync();

            if (clientes.Count == 0)
            {
                return NotFound();
            }

            return mapper.Map<List<ClienteDTO>>(clientes);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> RegistrarCliente(ClienteCreateDTO clienteCreateDTO)
        {
            var consultaCliente = await context.Cliente.FindAsync(clienteCreateDTO.PK_Cedula);

            if (consultaCliente != null)
            {
                return BadRequest($"El documento {clienteCreateDTO.PK_Cedula} ya se registro con anterioridad");
            }

            var cliente = mapper.Map<Cliente>(clienteCreateDTO);
            context.Add(cliente);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> ModificarCliente(long id, ClienteEditDTO clienteDTO)
        {
            var consultarCliente = await context.Cliente.AnyAsync(x => x.PK_Cedula == id);

            if (!consultarCliente)
            {
                return NotFound($"No se encontro el clienteDTO con la cedula {id}");
            }

            var modCliente = mapper.Map<Cliente>(clienteDTO);
            modCliente.PK_Cedula = id;
            context.Update(modCliente);
            await context.SaveChangesAsync();

            return NoContent();
        }


        [HttpDelete("{id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "Admin")]
        public async Task<ActionResult> EliminarrCliente(long id)
        {
            var consultarCliente = await context.Cliente.FindAsync(id);

            if (consultarCliente == null)
            {
                return NotFound($"No se encontro el clienteDTO con la cedula {id}");
            }

            context.Remove(consultarCliente);
            await context.SaveChangesAsync();

            return Ok();
        }
    }
}
