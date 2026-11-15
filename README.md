# Adopciones – Huellitas SPS (API)

API REST en C# (.NET 10) con arquitectura limpia: Domain, Application, Infrastructure y Api.

## Ejecutar
1. Configurar la cadena de conexión (User Secrets):
   ```
   cd Adopciones.Api
   dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Server=(localdb)\MSSQLLocalDB;Database=HuellitasDb;Trusted_Connection=True;TrustServerCertificate=True"
   cd ..
   ```
2. Aplicar migraciones:
   ```
   dotnet ef database update --project Adopciones.Infrastructure --startup-project Adopciones.Api
   ```
3. Ejecutar: `dotnet run --project Adopciones.Api` y abrir `/scalar/v1`.
