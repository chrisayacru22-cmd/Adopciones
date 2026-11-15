using Adopciones.Application.Interfaces;
using Adopciones.Domain.Entities;
using Adopciones.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Adopciones.Infrastructure.Repositories;

public class EspecieRepository : IEspecieRepository
{
    private readonly AppDbContext _db;

    public EspecieRepository(AppDbContext db) => _db = db;

    public Task<List<Especie>> GetAllAsync() =>
        _db.Especies.AsNoTracking().ToListAsync();
}
