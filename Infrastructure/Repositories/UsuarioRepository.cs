using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly PruebaAppContext context;

        public UsuarioRepository(PruebaAppContext _context)
        {
            this.context = _context;
        }

        public void Create(Usuario usuario)
        {
            context.Usuarios.Add(usuario);
            Save();
        }

        public void Delete(Usuario usuario)
        {
            context.Usuarios.Remove(usuario);
            Save();
        }

        public Usuario? Get(int id)
        {
            return context.Usuarios.Find(id);
        }

        public ICollection<Usuario> GetAll()
        {
            return context.Usuarios
                .Include(u => u.Cargo)
                .Include(u => u.Departamento)
                .ToList();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Usuario usuario)
        {
            context.Usuarios.Update(usuario);
            Save();
        }
    }
}
