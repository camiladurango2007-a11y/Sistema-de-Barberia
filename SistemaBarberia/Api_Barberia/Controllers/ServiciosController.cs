using lib_Barberia.Entidades;
using Lib_Barberia.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api_Barberia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServiciosController : ControllerBase
    {
        private readonly IServiciosAplicacion _app;

        public ServiciosController(IServiciosAplicacion app)
        {
            _app = app;
        }

        [HttpGet]
        public ActionResult<List<Servicios>> Listar() => _app.Listar();

        [HttpPost]
        public ActionResult<Servicios> Guardar(Servicios entidad) => _app.Guardar(entidad);

        [HttpPut]
        public ActionResult<Servicios> Modificar(Servicios entidad) => _app.Modificar(entidad);

        [HttpDelete]
        public ActionResult<Servicios> Borrar(Servicios entidad) => _app.Borrar(entidad);
    }
}
