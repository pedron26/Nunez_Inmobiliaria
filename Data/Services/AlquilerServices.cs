using Azure.Core;
using Microsoft.EntityFrameworkCore;
using Nuñez_Inmobiliaria.Data.Context;
using Nuñez_Inmobiliaria.Data.Entities;
using Nuñez_Inmobiliaria.Data.Request;
using Nuñez_Inmobiliaria.Data.Response;
using System.Data.Entity;

namespace Nuñez_Inmobiliaria.Data.Services
{
    public class AlquilerServices : IAlquilerServices
    {



        private readonly INunezInmobiliariaDbContext dbContext;

        public AlquilerServices(INunezInmobiliariaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Result> Crear(AlquilerRequest request)
        {
            try
            {
                var alquiler = Alquiler.Crear(request);
                dbContext.Alquileres.Add(alquiler);
                await dbContext.SaveChangesAsync();
                return new Result() { Message = "Ok", Success = true };
            }
            catch (Exception ex)
            {
                return new Result() { Message = ex.Message, Success = false };
            }
        }

        public async Task<Result> Modificar(AlquilerRequest request)
        {
            try
            {
                var alquiler = await dbContext.Alquileres.FirstOrDefaultAsync(a => a.Id == request.Id);
                if (alquiler == null)
                    return new Result { Message = "No se encontró el alquiler", Success = false };

                alquiler.Modificar(request);
                await dbContext.SaveChangesAsync();

                return new Result() { Message = "Ok", Success = true };
            }
            catch (Exception ex)
            {
                return new Result() { Message = ex.Message, Success = false };
            }
        }

        public async Task<Result> Eliminar(AlquilerRequest request)
        {
            try
            {
                var alquiler = await dbContext.Alquileres.FirstOrDefaultAsync(a => a.Id == request.Id);
                if (alquiler == null)
                    return new Result() { Message = "No se encontró el alquiler", Success = false };

                dbContext.Alquileres.Remove(alquiler);
                await dbContext.SaveChangesAsync();

                return new Result() { Message = "Ok", Success = true };
            }
            catch (Exception ex)
            {
                return new Result() { Message = ex.Message, Success = false };
            }
        }

        public async Task<Result<List<AlquilerResponse>>> Consultar(string filtro)
        {
            try
            {
                var alquileres = await dbContext.Alquileres
                    .Where(a => a.Cliente.Nombre.ToLower().Contains(filtro.ToLower()) ||
                                a.Inmueble.Descripcion!.ToLower().Contains(filtro.ToLower()))
                    .Select(a => a.ToResponse())
                    .ToListAsync();

                return new Result<List<AlquilerResponse>>()
                {
                    Message = "OK",
                    Success = true,
                    Data = alquileres
                };
            }
            catch (Exception ex)
            {
                return new Result<List<AlquilerResponse>>()
                {
                    Message = ex.Message,
                    Success = false
                };
            }
        }




    }
}

