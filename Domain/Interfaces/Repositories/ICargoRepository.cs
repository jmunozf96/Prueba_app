using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface ICargoRepository
    {
        ICollection<Cargo> ObtenerCargos();
    }
}
