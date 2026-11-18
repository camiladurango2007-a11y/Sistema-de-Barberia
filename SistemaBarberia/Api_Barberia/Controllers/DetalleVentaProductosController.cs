using lib_Barberia.Entidades;
using Lib_Barberia.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api_Barberia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DetalleVentaProductosController : ControllerBase
    {
        private readonly IDetalleVentaProductosAplicacion _app;

        public DetalleVentaProductosController(IDetalleVentaProductosAplicacion app)
        {
            _app = app;
        }

        [HttpGet]
        public ActionResult<List<DetalleVentaProductos>> Listar() => _app.Listar();

        [HttpPost]
        public ActionResult<DetalleVentaProductos> Guardar(DetalleVentaProductos entidad) => _app.Guardar(entidad);

        [HttpPut]
        public ActionResult<DetalleVentaProductos> Modificar(DetalleVentaProductos entidad) => _app.Modificar(entidad);

        [HttpDelete]
        public ActionResult<DetalleVentaProductos> Borrar(DetalleVentaProductos entidad) => _app.Borrar(entidad);
    }
}
