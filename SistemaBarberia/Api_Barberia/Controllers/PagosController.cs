using lib_Barberia.Entidades;
using Lib_Barberia.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api_Barberia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PagosController : ControllerBase
    {
        private readonly IPagosAplicacion _app;

        public PagosController(IPagosAplicacion app)
        {
            _app = app;
        }

        [HttpGet]
        public ActionResult<List<Pagos>> Listar() => _app.Listar();

        [HttpPost]
        public ActionResult<Pagos> Guardar(Pagos entidad) => _app.Guardar(entidad);

        [HttpPut]
        public ActionResult<Pagos> Modificar(Pagos entidad) => _app.Modificar(entidad);

        [HttpDelete]
        public ActionResult<Pagos> Borrar(Pagos entidad) => _app.Borrar(entidad);
    }
}
