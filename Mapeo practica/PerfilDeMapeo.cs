using AutoMapper;
namespace Mapeo_practica
{
    public class PerfilDeMapeo : Profile
    {
        public PerfilDeMapeo()
        {
            CreateMap<Usuario, UsuarioDTO>()
                .ForMember(dest => dest.NombreCompleto, opt => opt.MapFrom(src => src.Nombre));

        }
    }
}
