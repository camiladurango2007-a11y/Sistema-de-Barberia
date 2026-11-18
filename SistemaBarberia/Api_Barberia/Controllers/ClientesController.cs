using lib_Barberia.Entidades;
using Lib_Barberia.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api_Barberia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly IClientesAplicacion _app;

        public ClientesController(IClientesAplicacion app)
        {
            _app = app;
        }

        [HttpGet]
        public ActionResult<List<Clientes>> Listar() => _app.Listar();

        [HttpPost]
        public ActionResult<Clientes> Guardar(Clientes entidad) => _app.Guardar(entidad);

        [HttpPut]
        public ActionResult<Clientes> Modificar(Clientes entidad) => _app.Modificar(entidad);

        [HttpDelete]
        public ActionResult<Clientes> Borrar(Clientes entidad) => _app.Borrar(entidad);
    }
}
