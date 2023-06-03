using Azure.Core;
using Microsoft.EntityFrameworkCore;
using Nuñez_Inmobiliaria.Data.Context;
using Nuñez_Inmobiliaria.Data.Entities;
using System.Data.Entity;

namespace Nuñez_Inmobiliaria.Data.Services
{
    public class AlquilerServices : IAlquilerServices 
    {
        public class Result
        {
            public bool Success { get; set; }
            public string? Message { get; set; }
        }


        private readonly INunezInmobiliariaDbContext dbContext;

        public AlquilerServices(INunezInmobiliariaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Alquiler> ObtenerAlquiler(int id)
        {

            var alquiler = await dbContext.Alquileres.FirstOrDefaultAsync(a => a.Id == id);
            return alquiler;

        }



        public async Task<List<Alquiler>> ObtenerAlquileresPorCliente(int clienteId)
        {
        var alquileres = await dbContext.Alquileres
        .Where(a => a.ClienteId == clienteId)
        .ToListAsync();

        return alquileres;
    }

        public async Task CrearAlquiler(Alquiler alquiler)
        {
            dbContext.Alquileres.Add(alquiler);
            await dbContext.SaveChangesAsync();
        }

        public async Task ActualizarAlquiler(Alquiler alquiler)
        {
            var alquilerExistente = await dbContext.Alquileres.FirstOrDefaultAsync(a => a.Id == alquiler.Id);

            if (alquilerExistente != null)
            {
                alquilerExistente.InmuebleId = alquiler.InmuebleId;
                alquilerExistente.ClienteId = alquiler.ClienteId;
                alquilerExistente.FechaInicio = alquiler.FechaInicio;
                alquilerExistente.FechaCulminacion = alquiler.FechaCulminacion;

                await dbContext.SaveChangesAsync();
            }


        }
        public async Task EliminarAlquiler(int id)
        {
            var alquilerExistente = await dbContext.Alquileres.FirstOrDefaultAsync(a => a.Id == id);

            if (alquilerExistente != null)
            {
                dbContext.Alquileres.Remove(alquilerExistente);
                await dbContext.SaveChangesAsync();
            }
        }


    }
}
