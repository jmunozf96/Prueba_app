using Domain.Dtos;

namespace Domain.Interfaces.Services
{
    public interface IDepartamentoService
    {
        IEnumerable<DepartamentoDTO> ObtenerDepartamentos();
    }
}
