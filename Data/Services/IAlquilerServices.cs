using Nuñez_Inmobiliaria.Data.Request;
using Nuñez_Inmobiliaria.Data.Response;

namespace Nuñez_Inmobiliaria.Data.Services
{
    public interface IAlquilerServices
    {
        Task<Result<List<AlquilerResponse>>> Consultar(string filtro);
        Task<Result> Crear(AlquilerRequest request);
        Task<Result> Modificar(AlquilerRequest request);
        Task<Result> Eliminar(AlquilerRequest request);
        


    }
}