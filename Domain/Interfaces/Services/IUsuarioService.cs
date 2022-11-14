using Domain.Dtos.Usuario;
using System;
namespace Domain.Interfaces.Services
{
    public interface IUsuarioService
    {
        void Create(CreateUsuarioDTO usuario);
        void Update(UpdateUsuarioDTO usuario);
        void Delete(UpdateUsuarioDTO usuario);
        ICollection<UsuarioDTO> GetAll();
    }
}
