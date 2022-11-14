using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Prueba_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentoController : Controller
    {
        private readonly IDepartamentoService _service;

        public DepartamentoController(IDepartamentoService service)
        {
            _service = service;
        }

        [HttpGet("ObtenerDepartamentos")]
        public IActionResult ObtenerDepartamentos()
        {
            return Accepted(this._service.ObtenerDepartamentos());
        }
    }
}
