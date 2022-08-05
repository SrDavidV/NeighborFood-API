using AutoMapper;
using NeighbodFood2.Models;
using Neighborfood.DTOs;


namespace Neighborfood.Utilidades
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<ClienteCreateDTO, Cliente>();
            CreateMap<Cliente, ClienteDTO>();
            CreateMap<ClienteEditDTO, Cliente>();
            CreateMap<Reseña, ReseñaDTO>();
            CreateMap<ReseñaDTO, Reseña>();
            CreateMap<ReseñaCreacionDTO, Reseña>();
        }
    }
}
