using AutoMapper;
using Domain.Dtos.Usuario;
using Domain.Entities;

namespace Services.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<Usuario, UsuarioDTO>();
            CreateMap<CreateUsuarioDTO, Usuario>();
            CreateMap<UpdateUsuarioDTO, Usuario>();
        }
    }
}
