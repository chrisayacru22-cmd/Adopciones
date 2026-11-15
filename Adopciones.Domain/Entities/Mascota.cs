using Adopciones.Domain.Enums;

namespace Adopciones.Domain.Entities;

public class Mascota
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;      // máx. 50, obligatorio
    public int EspecieId { get; set; }
    public Especie? Especie { get; set; }
    public string Raza { get; set; } = "Mestizo";           // máx. 50, opcional
    public int EdadMeses { get; set; }                      // entre 0 y 300
    public Sexo Sexo { get; set; }
    public Tamano Tamano { get; set; }
    public bool Vacunada { get; set; }
    public bool Esterilizada { get; set; }
    public string Historia { get; set; } = string.Empty;    // máx. 1500, obligatoria
    public EstadoMascota Estado { get; set; } = EstadoMascota.Disponible;
    public string? FotoRuta { get; set; }
    public string? VideoRuta { get; set; }
}
