using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository
    {
        void Create(Usuario usuario);
        void Update(Usuario usuario);
        void Delete(Usuario usuario);
        ICollection<Usuario> GetAll();
        void Save();
    }
}
