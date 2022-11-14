using AutoMapper;
using Domain.Dtos;
using Domain.Interfaces.Services;
using Domain.Interfaces.Repositories;

namespace Services
{
    public class DepartamentoService : IDepartamentoService
    {
        private readonly IDepartamentoRepository _departamentoRepository;
        private readonly IMapper _mapper;

        public DepartamentoService(IDepartamentoRepository departamentoRepository, IMapper mapper)
        {
            _departamentoRepository = departamentoRepository;
            _mapper = mapper;
        }

        public IEnumerable<DepartamentoDTO> ObtenerDepartamentos()
        {
            var departamentos = _departamentoRepository.ObtenerDepartamentos();
            return _mapper.Map<IEnumerable<DepartamentoDTO>>(departamentos);
        }
    }
}
