using lib_Barberia.Entidades;
using Lib_Barberia.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api_Barberia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriasProductoController : ControllerBase
    {
        private readonly ICategoriasProductoAplicacion _app;

        public CategoriasProductoController(ICategoriasProductoAplicacion app)
        {
            _app = app;
        }

        [HttpGet]
        public ActionResult<List<CategoriasProducto>> Listar() => _app.Listar();

        [HttpPost]
        public ActionResult<CategoriasProducto> Guardar(CategoriasProducto entidad) => _app.Guardar(entidad);

        [HttpPut]
        public ActionResult<CategoriasProducto> Modificar(CategoriasProducto entidad) => _app.Modificar(entidad);

        [HttpDelete]
        public ActionResult<CategoriasProducto> Borrar(CategoriasProducto entidad) => _app.Borrar(entidad);
    }
}
