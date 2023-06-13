using Nuñez_Inmobiliaria.Data.Context;
using Nuñez_Inmobiliaria.Data.Entities;
using System.Data.Entity;
using System.Reflection.Metadata.Ecma335;

namespace Nuñez_Inmobiliaria.Data.Services
{
    public class InmuebleServices : IInmuebleServices
    {
        private readonly INunezInmobiliariaDbContext dbContext;
        public InmuebleServices(INunezInmobiliariaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<List<Inmueble>> GetAllInmueblesAsync()
        {
            return await dbContext.Inmuebles.ToListAsync();
        }

        public async Task<Inmueble> ObtenerInmuebleByIdAsync(int id)
        {
            var inmueble = await dbContext.Inmuebles.FindAsync(id);
            if (inmueble == null)
            {
                throw new InvalidOperationException("El inmueble no se encontró.");
            }
            return inmueble!;
        }

        public async Task CrearInmuebleAsync(Inmueble inmueble)
        {
            dbContext.Inmuebles.Add(inmueble);
            await dbContext.SaveChangesAsync();
        }

        public async Task ActualizarInmuebleAsync(Inmueble inmueble)
        {
            var inmuebleExistente = await dbContext.Inmuebles.FindAsync(inmueble.Id);
            if (inmuebleExistente != null)
            {
                dbContext.Inmuebles.Update(inmueble);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task EliminarInmuebleAsync(int id)
        {
            var inmueble = await dbContext.Inmuebles.FindAsync(id);
            if (inmueble != null)
            {
                dbContext.Inmuebles.Remove(inmueble);
                await dbContext.SaveChangesAsync();
            }
        }
    }



}
  

    
  

