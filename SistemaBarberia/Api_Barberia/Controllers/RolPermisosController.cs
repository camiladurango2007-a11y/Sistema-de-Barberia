using lib_Barberia.Entidades;
using Lib_Barberia.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api_Barberia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RolPermisosController : ControllerBase
    {
        private readonly IRolPermisosAplicacion _app;

        public RolPermisosController(IRolPermisosAplicacion app)
        {
            _app = app;
        }

        [HttpGet]
        public ActionResult<List<RolPermisos>> Listar() => _app.Listar();

        [HttpPost]
        public ActionResult<RolPermisos> Guardar(RolPermisos entidad) => _app.Guardar(entidad);

        [HttpPut]
        public ActionResult<RolPermisos> Modificar(RolPermisos entidad) => _app.Modificar(entidad);

        [HttpDelete]
        public ActionResult<RolPermisos> Borrar(RolPermisos entidad) => _app.Borrar(entidad);
    }
}
