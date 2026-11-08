using lib_Barberia.Entidades;
using Lib_Barberia.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api_Barberia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VentaProductosController : ControllerBase
    {
        private readonly IVentaProductosAplicacion _app;

        public VentaProductosController(IVentaProductosAplicacion app)
        {
            _app = app;
        }

        [HttpGet]
        public ActionResult<List<VentaProductos>> Listar() => _app.Listar();

        [HttpPost]
        public ActionResult<VentaProductos> Guardar(VentaProductos entidad) => _app.Guardar(entidad);

        [HttpPut]
        public ActionResult<VentaProductos> Modificar(VentaProductos entidad) => _app.Modificar(entidad);

        [HttpDelete]
        public ActionResult<VentaProductos> Borrar(VentaProductos entidad) => _app.Borrar(entidad);
    }
}
