using Domain.Dtos;

namespace Domain.Interfaces.Services
{
    public interface ICargoService
    {
        IEnumerable<CargoDTO> ObtenerCargos();
    }
}
