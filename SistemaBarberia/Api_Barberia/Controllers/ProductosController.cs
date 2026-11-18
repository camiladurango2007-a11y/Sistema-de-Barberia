using lib_Barberia.Entidades;
using Lib_Barberia.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api_Barberia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : ControllerBase
    {
        private readonly IProductosAplicacion _app;

        public ProductosController(IProductosAplicacion app)
        {
            _app = app;
        }

        [HttpGet]
        public ActionResult<List<Productos>> Listar() => _app.Listar();

        [HttpPost]
        public ActionResult<Productos> Guardar(Productos entidad) => _app.Guardar(entidad);

        [HttpPut]
        public ActionResult<Productos> Modificar(Productos entidad) => _app.Modificar(entidad);

        [HttpDelete]
        public ActionResult<Productos> Borrar(Productos entidad) => _app.Borrar(entidad);
    }
}
