using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infrastructure.Data.Contexts;

namespace Infrastructure.Repositories
{
    public class DepartamentoRepository : IDepartamentoRepository
    {
        private readonly PruebaAppContext context;

        public DepartamentoRepository(PruebaAppContext _context)
        {
            this.context = _context;
        }

        public ICollection<Departamento> ObtenerDepartamentos()
        {
            return context.Departamentos.Where(c => c.Activo == true).ToList();
        }
    }
}
