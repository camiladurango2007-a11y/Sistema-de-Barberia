using lib_Barberia.Entidades;
using Lib_Barberia.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api_Barberia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuariosAplicacion _app;

        public UsuariosController(IUsuariosAplicacion app)
        {
            _app = app;
        }

        [HttpGet]
        public ActionResult<List<Usuarios>> Listar() => _app.Listar();

        [HttpPost]
        public ActionResult<Usuarios> Guardar(Usuarios entidad) => _app.Guardar(entidad);

        [HttpPut]
        public ActionResult<Usuarios> Modificar(Usuarios entidad) => _app.Modificar(entidad);

        [HttpDelete]
        public ActionResult<Usuarios> Borrar(Usuarios entidad) => _app.Borrar(entidad);
    }
}
