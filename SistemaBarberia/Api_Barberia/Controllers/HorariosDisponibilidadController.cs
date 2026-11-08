using lib_Barberia.Entidades;
using Lib_Barberia.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api_Barberia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HorariosDisponibilidadController : ControllerBase
    {
        private readonly IHorariosDisponibilidadAplicacion _app;

        public HorariosDisponibilidadController(IHorariosDisponibilidadAplicacion app)
        {
            _app = app;
        }

        [HttpGet]
        public ActionResult<List<HorariosDisponibilidad>> Listar() => _app.Listar();

        [HttpPost]
        public ActionResult<HorariosDisponibilidad> Guardar(HorariosDisponibilidad entidad) => _app.Guardar(entidad);

        [HttpPut]
        public ActionResult<HorariosDisponibilidad> Modificar(HorariosDisponibilidad entidad) => _app.Modificar(entidad);

        [HttpDelete]
        public ActionResult<HorariosDisponibilidad> Borrar(HorariosDisponibilidad entidad) => _app.Borrar(entidad);
    }
}
