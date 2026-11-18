using lib_Barberia.Entidades;
using Lib_Barberia.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api_Barberia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BarberosController : ControllerBase
    {
        private readonly IBarberosAplicacion _app;

        public BarberosController(IBarberosAplicacion app)
        {
            _app = app;
        }

        [HttpGet]
        public ActionResult<List<Barberos>> Listar() => _app.Listar();

        [HttpPost]
        public ActionResult<Barberos> Guardar(Barberos entidad) => _app.Guardar(entidad);

        [HttpPut]
        public ActionResult<Barberos> Modificar(Barberos entidad) => _app.Modificar(entidad);

        [HttpDelete]
        public ActionResult<Barberos> Borrar(Barberos entidad) => _app.Borrar(entidad);
    }
}
