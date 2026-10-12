using lib_Barberia.Interfaces;
using Lib_Barberia.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace asp_servicios_barberia.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BarberiaController : ControllerBase
    {
        private IConexion conexion;

        public BarberiaController(IConexion conexion)
        {
            this.conexion = conexion;
            this.conexion.StringConexion = "Server=.\\SQLEXPRESS;Database=BD_Barberia;Trusted_Connection=True;TrustServerCertificate=True;";
        }

        [HttpGet]
        public IActionResult ObtenerTodo()
        {
            var respuesta = new Dictionary<string, object>();

            try
            {
                // Usamos .Take(1).ToList() para limitar el resultado a un solo registro por tabla[cite: 16]
                respuesta["Barberos"] = this.conexion.Barberos!.Take(1).ToList();
                respuesta["CajasDiarias"] = this.conexion.CajasDiarias!.Take(1).ToList();
                respuesta["CategoriasProducto"] = this.conexion.CategoriasProducto!.Take(1).ToList();
                respuesta["CitaServicios"] = this.conexion.CitaServicios!.Take(1).ToList();
                respuesta["Citas"] = this.conexion.Citas!.Take(1).ToList();
                respuesta["Clientes"] = this.conexion.Clientes!.Take(1).ToList();
                respuesta["DetalleVentaProductos"] = this.conexion.DetalleVentaProductos!.Take(1).ToList();
                respuesta["HorariosDisponibilidad"] = this.conexion.HorariosDisponibilidad!.Take(1).ToList();
                respuesta["MetodosPago"] = this.conexion.MetodosPago!.Take(1).ToList();
                respuesta["Pagos"] = this.conexion.Pagos!.Take(1).ToList();
                respuesta["Permisos"] = this.conexion.Permisos!.Take(1).ToList();
                respuesta["Productos"] = this.conexion.Productos!.Take(1).ToList();
                respuesta["Promociones"] = this.conexion.Promociones!.Take(1).ToList();
                respuesta["Proveedores"] = this.conexion.Proveedores!.Take(1).ToList();
                respuesta["Roles"] = this.conexion.Roles!.Take(1).ToList();
                respuesta["RolPermisos"] = this.conexion.RolPermisos!.Take(1).ToList();
                respuesta["Servicios"] = this.conexion.Servicios!.Take(1).ToList();
                respuesta["Sucursales"] = this.conexion.Sucursales!.Take(1).ToList();
                respuesta["Usuarios"] = this.conexion.Usuarios!.Take(1).ToList();
                respuesta["VentaProductos"] = this.conexion.VentaProductos!.Take(1).ToList();

                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}