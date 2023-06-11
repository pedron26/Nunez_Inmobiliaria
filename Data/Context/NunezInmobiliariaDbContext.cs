using Microsoft.EntityFrameworkCore;
using Nuñez_Inmobiliaria.Data.Entities;

namespace Nuñez_Inmobiliaria.Data.Context
{
    public class NunezInmobiliariaDbContext : DbContext, INunezInmobiliariaDbContext
    {
        private readonly IConfiguration config;

        public NunezInmobiliariaDbContext(IConfiguration config)
        {
            this.config = config;
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Alquiler> Alquileres { get; set; }
        public DbSet<Inmueble> Inmuebles { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: config.GetConnectionString("MSSQL"));
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }


    }
}
