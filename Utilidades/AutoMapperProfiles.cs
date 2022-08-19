using AutoMapper;
using NeighbodFood2.DTOs;
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
            CreateMap<Restaurante, RestauranteDTO>().ReverseMap();
            CreateMap<RestauranteCreacionDTO, Restaurante>()
                 .ForMember(x => x.RESTA_Imagen, options => options.Ignore());

            CreateMap<Categoria, CategoriaCreacionDTO>().ForMember(x => x.CategoriaImagen,
                options => options.Ignore());

            CreateMap<CategoriaCreacionDTO, Categoria>().ForMember(x => x.CategoriaImagen,
                options => options.Ignore());

            CreateMap<Categoria, CategoriaDTO>().ReverseMap();
        }
    }
}
