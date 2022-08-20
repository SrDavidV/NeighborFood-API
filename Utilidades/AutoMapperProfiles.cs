using AutoMapper;
using NeighbodFood2.DTOs;
using NeighbodFood2.Models;
using Neighborfood.DTOs;
using NetTopologySuite.Geometries;

namespace Neighborfood.Utilidades
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles(GeometryFactory geometryFactory)
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

            CreateMap<Sede, SedeDTO>()
                .ForMember(x => x.Latitud, x => x.MapFrom(y => y.Ubicacion.Y))
                .ForMember(x => x.Longitud, x => x.MapFrom(y => y.Ubicacion.X));

            CreateMap<SedeDTO, Sede>()
                .ForMember(x => x.Ubicacion, x => x.MapFrom(y =>
                geometryFactory.CreatePoint(new Coordinate(y.Latitud, y.Latitud))));

            CreateMap<SedeCreacionDTO, Sede>()
               .ForMember(x => x.Ubicacion, x => x.MapFrom(y =>
               geometryFactory.CreatePoint(new Coordinate(y.Latitud, y.Latitud))));
        }
    }
}
