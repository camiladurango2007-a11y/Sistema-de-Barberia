using lib_Barberia.Implementaciones;
using Lib_Barberia.Interfaces;
using Lib_Barberia.Implementaciones;
using lib_Barberia.Interfaces;
using Lib_Barberia.Nucleo;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddJsonOptions(o =>
    o.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddScoped<IConexion>(sp => new Conexion
{
    StringConexion = DatosGenerales.ObtenerStringConnection()
});

builder.Services.AddScoped<IBarberosAplicacion, BarberosAplicacion>();
builder.Services.AddScoped<ICajasDiariasAplicacion, CajasDiariasAplicacion>();
builder.Services.AddScoped<ICategoriasProductoAplicacion, CategoriasProductoAplicacion>();
builder.Services.AddScoped<ICitaServiciosAplicacion, CitaServiciosAplicacion>();
builder.Services.AddScoped<ICitasAplicacion, CitasAplicacion>();
builder.Services.AddScoped<IClientesAplicacion, ClientesAplicacion>();
builder.Services.AddScoped<IDetalleVentaProductosAplicacion, DetalleVentaProductosAplicacion>();
builder.Services.AddScoped<IHorariosDisponibilidadAplicacion, HorariosDisponibilidadAplicacion>();
builder.Services.AddScoped<IMetodosPagoAplicacion, MetodosPagoAplicacion>();
builder.Services.AddScoped<IPagosAplicacion, PagosAplicacion>();
builder.Services.AddScoped<IPermisosAplicacion, PermisosAplicacion>();
builder.Services.AddScoped<IProductosAplicacion, ProductosAplicacion>();
builder.Services.AddScoped<IPromocionesAplicacion, PromocionesAplicacion>();
builder.Services.AddScoped<IProveedoresAplicacion, ProveedoresAplicacion>();
builder.Services.AddScoped<IRolPermisosAplicacion, RolPermisosAplicacion>();
builder.Services.AddScoped<IRolesAplicacion, RolesAplicacion>();
builder.Services.AddScoped<IServiciosAplicacion, ServiciosAplicacion>();
builder.Services.AddScoped<ISucursalesAplicacion, SucursalesAplicacion>();
builder.Services.AddScoped<IUsuariosAplicacion, UsuariosAplicacion>();
builder.Services.AddScoped<IVentaProductosAplicacion, VentaProductosAplicacion>();

var app = builder.Build();

app.UseAuthorization();
app.MapControllers();
app.Run();
