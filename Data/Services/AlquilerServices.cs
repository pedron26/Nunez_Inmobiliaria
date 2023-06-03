using Nuñez_Inmobiliaria.Data.Context;

namespace Nuñez_Inmobiliaria.Data.Services
{
    public class AlquilerServices
    {
        private readonly INunezInmobiliariaDbContext dbContext;

        public AlquilerServices(INunezInmobiliariaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        
    }
}
