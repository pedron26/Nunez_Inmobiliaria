using Microsoft.EntityFrameworkCore;
using Nuñez_Inmobiliaria.Data.Entities;

namespace Nuñez_Inmobiliaria.Data.Context
{
    public interface INunezInmobiliariaDbContext
    {
        public DbSet<Cliente> Clientes { get; set; }


        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        
    }
}