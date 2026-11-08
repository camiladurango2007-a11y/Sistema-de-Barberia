using lib_Barberia.Entidades;
using Lib_Barberia.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api_Barberia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PromocionesController : ControllerBase
    {
        private readonly IPromocionesAplicacion _app;

        public PromocionesController(IPromocionesAplicacion app)
        {
            _app = app;
        }

        [HttpGet]
        public ActionResult<List<Promociones>> Listar() => _app.Listar();

        [HttpPost]
        public ActionResult<Promociones> Guardar(Promociones entidad) => _app.Guardar(entidad);

        [HttpPut]
        public ActionResult<Promociones> Modificar(Promociones entidad) => _app.Modificar(entidad);

        [HttpDelete]
        public ActionResult<Promociones> Borrar(Promociones entidad) => _app.Borrar(entidad);
    }
}
