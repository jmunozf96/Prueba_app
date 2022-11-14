using AutoMapper;
using Domain.Dtos.Usuario;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repository;
        private readonly IMapper _mapper;

        public UsuarioService(IUsuarioRepository repository, IMapper mapper) 
        {
            _repository = repository;
            _mapper = mapper;

        }

        public void Create(CreateUsuarioDTO usuario)
        {
            var usuario_map = _mapper.Map<Usuario>(usuario);
            _repository.Create(usuario_map);
        }

        public void Delete(int usuario)
        {
            _repository.Delete(usuario);
        }

        public ICollection<UsuarioDTO> GetAll()
        {
            var usuarios = _repository.GetAll();
            return _mapper.Map<ICollection<UsuarioDTO>>(usuarios);
        }

        public void Update(UpdateUsuarioDTO usuario)
        {
            var usuario_map = _mapper.Map<Usuario>(usuario);
            _repository.Update(usuario_map);
        }
    }
}
