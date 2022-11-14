using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infrastructure.Data.Contexts;

namespace Infrastructure.Repositories
{
    public class CargoRepository : ICargoRepository
    {
        private readonly PruebaAppContext context;

        public CargoRepository(PruebaAppContext _context)
        {
            this.context = _context;
        }

        public ICollection<Cargo> ObtenerCargos()
        {
            return context.Cargos.Where(c => c.Activo == true).ToList();
        }
    }
}
