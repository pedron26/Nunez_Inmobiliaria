using Nuñez_Inmobiliaria.Data.Entities;

namespace Nuñez_Inmobiliaria.Data.Services
{
    public interface IInmuebleServices
    {
        Task<List<Inmueble>> ObtenerInmuebles();
        Task<Inmueble> ObtenerInmueblePorId(int id);
        Task<bool> GuardarInmueble(Inmueble inmueble);
        Task<bool> ActualizarInmueble(Inmueble inmueble);
        Task<bool> EliminarInmueble(int id);
    }
}