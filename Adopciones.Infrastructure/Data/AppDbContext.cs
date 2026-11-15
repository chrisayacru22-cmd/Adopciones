using Adopciones.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Adopciones.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Especie> Especies => Set<Especie>();
    public DbSet<Mascota> Mascotas => Set<Mascota>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Especie>(e =>
        {
            e.Property(x => x.Nombre).HasMaxLength(50).IsRequired();

            // Datos semilla del catálogo
            e.HasData(
                new Especie { Id = 1, Nombre = "Perro" },
                new Especie { Id = 2, Nombre = "Gato" },
                new Especie { Id = 3, Nombre = "Otro" });
        });

        modelBuilder.Entity<Mascota>(e =>
        {
            e.Property(x => x.Nombre).HasMaxLength(50).IsRequired();
            e.Property(x => x.Raza).HasMaxLength(50);
            e.Property(x => x.Historia).HasMaxLength(1500).IsRequired();
            e.Property(x => x.Sexo).HasConversion<string>().HasMaxLength(20);
            e.Property(x => x.Tamano).HasConversion<string>().HasMaxLength(20);
            e.Property(x => x.Estado).HasConversion<string>().HasMaxLength(20);
            e.HasOne(x => x.Especie).WithMany().HasForeignKey(x => x.EspecieId);
        });
    }
}
