using lib_Barberia.Entidades;
using Lib_Barberia.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api_Barberia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CajasDiariasController : ControllerBase
    {
        private readonly ICajasDiariasAplicacion _app;

        public CajasDiariasController(ICajasDiariasAplicacion app)
        {
            _app = app;
        }

        [HttpGet]
        public ActionResult<List<CajasDiarias>> Listar() => _app.Listar();

        [HttpPost]
        public ActionResult<CajasDiarias> Guardar(CajasDiarias entidad) => _app.Guardar(entidad);

        [HttpPut]
        public ActionResult<CajasDiarias> Modificar(CajasDiarias entidad) => _app.Modificar(entidad);

        [HttpDelete]
        public ActionResult<CajasDiarias> Borrar(CajasDiarias entidad) => _app.Borrar(entidad);
    }
}
