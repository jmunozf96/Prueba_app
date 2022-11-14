using Domain.Dtos.Usuario;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Prueba_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService  _service;

        public UsuarioController(IUsuarioService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetAll());
        }

        [HttpPost]
        public virtual IActionResult Post([FromBody] CreateUsuarioDTO value)
        {
            _service.Create(value);
            return Ok();
        }

        [HttpPut("{id}")]
        public virtual IActionResult Put(int id, [FromBody] UpdateUsuarioDTO value)
        {
            return Accepted(_service.Update(id, value));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Accepted();
        }
    }
}
