using Domain.Dtos;

namespace Domain.Interfaces
{
    public interface IDepartamentoService
    {
        IEnumerable<DepartamentoDTO> ObtenerDepartamentos();
    }
}
