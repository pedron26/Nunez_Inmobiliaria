
namespace Nuñez_Inmobiliaria.Data.Services
{
    public interface IAlquilerServices
    {
        Task<Alquiler> ObtenerAlquiler(int id);
        Task<List<Alquiler>> ObtenerAlquileresPorCliente(int clienteId);
        Task ActualizarAlquiler(Alquiler alquiler);
        Task CrearAlquiler(Alquiler alquiler);
        Task EliminarAlquiler(int id);
        

    }
}