using Nuñez_Inmobiliaria.Data.Entities;

namespace Nuñez_Inmobiliaria.Data.Services
{
    public interface IInmuebleServices
    {
        Task<List<Inmueble>> GetAllInmueblesAsync();
        Task<Inmueble> ObtenerInmuebleByIdAsync(int id);
        Task CrearInmuebleAsync(Inmueble inmueble);
        Task ActualizarInmuebleAsync(Inmueble inmueble);
        Task EliminarInmuebleAsync(int id);
    }
}