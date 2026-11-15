using Adopciones.Application.Interfaces;
using Adopciones.Infrastructure.Data;
using Adopciones.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

// La cadena de conexión viene de User Secrets (no se sube a GitHub)
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Inyección de dependencias
builder.Services.AddScoped<IEspecieRepository, EspecieRepository>();

var app = builder.Build();

app.MapOpenApi();
app.MapScalarApiReference();

app.UseHttpsRedirection();

app.MapGet("/api/especies", async (IEspecieRepository repo) =>
    Results.Ok(await repo.GetAllAsync()))
   .WithName("GetEspecies");

app.Run();
