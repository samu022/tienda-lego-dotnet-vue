using Microsoft.EntityFrameworkCore;
using Proyecto_Tienda_Lego.DataAccess;

var builder = WebApplication.CreateBuilder(args);
//1. CONEXION A BD
const string CONNECTIONNAME = "LegoDB";
var connectionString = builder.Configuration.GetConnectionString(CONNECTIONNAME);
//2 Añadir contexto
builder.Services.AddDbContext<LegoDBContext>(options => options.UseSqlServer(connectionString));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
