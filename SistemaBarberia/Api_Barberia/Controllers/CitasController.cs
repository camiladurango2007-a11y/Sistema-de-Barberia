using lib_Barberia.Entidades;
using Lib_Barberia.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api_Barberia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitasController : ControllerBase
    {
        private readonly ICitasAplicacion _app;

        public CitasController(ICitasAplicacion app)
        {
            _app = app;
        }

        [HttpGet]
        public ActionResult<List<Citas>> Listar() => _app.Listar();

        [HttpPost]
        public ActionResult<Citas> Guardar(Citas entidad) => _app.Guardar(entidad);

        [HttpPut]
        public ActionResult<Citas> Modificar(Citas entidad) => _app.Modificar(entidad);

        [HttpDelete]
        public ActionResult<Citas> Borrar(Citas entidad) => _app.Borrar(entidad);
    }
}
