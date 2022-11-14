using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Prueba_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoController : Controller
    {
        private readonly ICargoService _service;

        public CargoController(ICargoService service)
        {
            _service = service;
        }

        [HttpGet("ObtenerCargos")]
        public IActionResult ObtenerCargos()
        {
            return Accepted(this._service.ObtenerCargos());
        }
    }
}
