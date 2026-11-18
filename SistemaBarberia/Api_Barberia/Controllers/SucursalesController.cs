using lib_Barberia.Entidades;
using Lib_Barberia.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api_Barberia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SucursalesController : ControllerBase
    {
        private readonly ISucursalesAplicacion _app;

        public SucursalesController(ISucursalesAplicacion app)
        {
            _app = app;
        }

        [HttpGet]
        public ActionResult<List<Sucursales>> Listar() => _app.Listar();

        [HttpPost]
        public ActionResult<Sucursales> Guardar(Sucursales entidad) => _app.Guardar(entidad);

        [HttpPut]
        public ActionResult<Sucursales> Modificar(Sucursales entidad) => _app.Modificar(entidad);

        [HttpDelete]
        public ActionResult<Sucursales> Borrar(Sucursales entidad) => _app.Borrar(entidad);
    }
}
