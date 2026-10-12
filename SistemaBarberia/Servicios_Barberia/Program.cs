using lib_Barberia.Implementaciones;
using lib_Barberia.Interfaces;
using Lib_Barberia.Implementaciones;
using Lib_Barberia.Interfaces;
using System.Text.Json.Serialization; // Necesario para evitar bucles JSON

var builder = WebApplication.CreateBuilder(args);

// 1. Agregamos los Controladores y cortamos los ciclos infinitos del JSON
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

// 2. Agregamos el servicio de Autorización (Esto soluciona el error de tu foto)
builder.Services.AddAuthorization();

// 3. Inyectamos la conexión a la base de datos
builder.Services.AddScoped<IConexion, Conexion>();

var app = builder.Build();

// Configuramos las rutas y peticiones HTTP
app.UseAuthorization();
app.MapControllers();

app.Run();