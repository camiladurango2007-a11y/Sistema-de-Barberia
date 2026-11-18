using lib_Barberia.Entidades;
using Lib_Barberia.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api_Barberia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PermisosController : ControllerBase
    {
        private readonly IPermisosAplicacion _app;

        public PermisosController(IPermisosAplicacion app)
        {
            _app = app;
        }

        [HttpGet]
        public ActionResult<List<Permisos>> Listar() => _app.Listar();

        [HttpPost]
        public ActionResult<Permisos> Guardar(Permisos entidad) => _app.Guardar(entidad);

        [HttpPut]
        public ActionResult<Permisos> Modificar(Permisos entidad) => _app.Modificar(entidad);

        [HttpDelete]
        public ActionResult<Permisos> Borrar(Permisos entidad) => _app.Borrar(entidad);
    }
}
