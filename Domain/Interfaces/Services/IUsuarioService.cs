using Domain.Dtos.Usuario;
using System;
namespace Domain.Interfaces.Services
{
    public interface IUsuarioService
    {
        void Create(CreateUsuarioDTO usuario);
        UpdateUsuarioDTO Update(int usuarioId, UpdateUsuarioDTO usuario);
        void Delete(int usuarioId);
        ICollection<UsuarioDTO> GetAll();
    }
}
