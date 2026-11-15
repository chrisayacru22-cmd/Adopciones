using Adopciones.Domain.Entities;

namespace Adopciones.Application.Interfaces;

public interface IEspecieRepository
{
    Task<List<Especie>> GetAllAsync();
}
