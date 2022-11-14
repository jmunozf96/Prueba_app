using AutoMapper;
using Domain.Dtos.Usuario;
using Domain.Entities;
using Domain.Exceptions;
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

        public void Delete(int usuarioId)
        {
            var _usuario = _repository.Get(usuarioId);
            if (_usuario == null) throw new NotFoundException();
            _repository.Delete(_usuario);
        }

        public ICollection<UsuarioDTO> GetAll()
        {
            var usuarios = _repository.GetAll();
            return _mapper.Map<ICollection<UsuarioDTO>>(usuarios);
        }

        public UpdateUsuarioDTO Update(int usuarioId, UpdateUsuarioDTO usuario)
        {
            var _usuario = _repository.Get(usuarioId);
            if (_usuario == null) throw new NotFoundException();
            var usuario_map = _mapper.Map(usuario, _usuario);
            _repository.Update(usuario_map);
            return _mapper.Map<UpdateUsuarioDTO>(usuario_map);
        }
    }
}
