using lib_Barberia.Entidades;
using Lib_Barberia.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api_Barberia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProveedoresController : ControllerBase
    {
        private readonly IProveedoresAplicacion _app;

        public ProveedoresController(IProveedoresAplicacion app)
        {
            _app = app;
        }

        [HttpGet]
        public ActionResult<List<Proveedores>> Listar() => _app.Listar();

        [HttpPost]
        public ActionResult<Proveedores> Guardar(Proveedores entidad) => _app.Guardar(entidad);

        [HttpPut]
        public ActionResult<Proveedores> Modificar(Proveedores entidad) => _app.Modificar(entidad);

        [HttpDelete]
        public ActionResult<Proveedores> Borrar(Proveedores entidad) => _app.Borrar(entidad);
    }
}
