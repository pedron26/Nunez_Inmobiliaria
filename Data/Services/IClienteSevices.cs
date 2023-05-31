using Nuñez_Inmobiliaria.Data.Request;
using Nuñez_Inmobiliaria.Data.Response;

namespace Nuñez_Inmobiliaria.Data.Services
{
    public interface IClienteSevices
    {
        Task<Result<List<ClienteResponse>>> Consultar(string filtro);
        Task<Result> Crear(ClienteRequest request);
        Task<Result> Eliminar(ClienteRequest request);
        Task<Result> Modificar(ClienteRequest request);

    }
}