using lib_Barberia.Interfaces;
using Lib_Barberia.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace asp_servicios_barberia.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HorariosDisponibilidadController : ControllerBase
    {
        private IConexion conexion;

        public HorariosDisponibilidadController(IConexion conexion)
        {
            this.conexion = conexion;
            this.conexion.StringConexion = "Server=.\\SQLEXPRESS;Database=BD_Barberia;Trusted_Connection=True;TrustServerCertificate=True;";
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(this.conexion.HorariosDisponibilidad!.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}