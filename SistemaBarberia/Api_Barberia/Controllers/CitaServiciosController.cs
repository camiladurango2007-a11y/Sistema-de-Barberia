using lib_Barberia.Entidades;
using Lib_Barberia.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api_Barberia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitaServiciosController : ControllerBase
    {
        private readonly ICitaServiciosAplicacion _app;

        public CitaServiciosController(ICitaServiciosAplicacion app)
        {
            _app = app;
        }

        [HttpGet]
        public ActionResult<List<CitaServicios>> Listar() => _app.Listar();

        [HttpPost]
        public ActionResult<CitaServicios> Guardar(CitaServicios entidad) => _app.Guardar(entidad);

        [HttpPut]
        public ActionResult<CitaServicios> Modificar(CitaServicios entidad) => _app.Modificar(entidad);

        [HttpDelete]
        public ActionResult<CitaServicios> Borrar(CitaServicios entidad) => _app.Borrar(entidad);
    }
}
