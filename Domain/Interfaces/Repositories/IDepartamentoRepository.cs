using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface IDepartamentoRepository
    {
        ICollection<Departamento> ObtenerDepartamentos();
    }
}
