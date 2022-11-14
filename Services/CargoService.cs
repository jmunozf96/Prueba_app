using Domain.Dtos;
using Domain.Interfaces.Services;
using AutoMapper;
using Domain.Interfaces.Repositories;

namespace Services
{
    public class CargoService : ICargoService
    {
        private readonly ICargoRepository _cargoRepository;
        private readonly IMapper _mapper;

        public CargoService(ICargoRepository cargoRepository, IMapper mapper)
        {
            _cargoRepository = cargoRepository;
            _mapper = mapper;
        }

        public IEnumerable<CargoDTO> ObtenerCargos()
        {
            var cargos = _cargoRepository.ObtenerCargos();
            return _mapper.Map<IEnumerable<CargoDTO>>(cargos);
        }
    }
}
