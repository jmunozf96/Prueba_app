using Domain.Dtos;

namespace Domain.Interfaces
{
    public interface ICargoService
    {
        IEnumerable<CargoDTO> ObtenerCargos();
    }
}
