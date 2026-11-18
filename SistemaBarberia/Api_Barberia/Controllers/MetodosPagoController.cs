using lib_Barberia.Entidades;
using Lib_Barberia.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api_Barberia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MetodosPagoController : ControllerBase
    {
        private readonly IMetodosPagoAplicacion _app;

        public MetodosPagoController(IMetodosPagoAplicacion app)
        {
            _app = app;
        }

        [HttpGet]
        public ActionResult<List<MetodosPago>> Listar() => _app.Listar();

        [HttpPost]
        public ActionResult<MetodosPago> Guardar(MetodosPago entidad) => _app.Guardar(entidad);

        [HttpPut]
        public ActionResult<MetodosPago> Modificar(MetodosPago entidad) => _app.Modificar(entidad);

        [HttpDelete]
        public ActionResult<MetodosPago> Borrar(MetodosPago entidad) => _app.Borrar(entidad);
    }
}
