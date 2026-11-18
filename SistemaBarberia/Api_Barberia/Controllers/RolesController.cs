using lib_Barberia.Entidades;
using Lib_Barberia.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api_Barberia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RolesController : ControllerBase
    {
        private readonly IRolesAplicacion _app;

        public RolesController(IRolesAplicacion app)
        {
            _app = app;
        }

        [HttpGet]
        public ActionResult<List<Roles>> Listar() => _app.Listar();

        [HttpPost]
        public ActionResult<Roles> Guardar(Roles entidad) => _app.Guardar(entidad);

        [HttpPut]
        public ActionResult<Roles> Modificar(Roles entidad) => _app.Modificar(entidad);

        [HttpDelete]
        public ActionResult<Roles> Borrar(Roles entidad) => _app.Borrar(entidad);
    }
}
