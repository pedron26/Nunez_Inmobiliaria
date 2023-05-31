using Nuñez_Inmobiliaria.Data.Request;

namespace Nuñez_Inmobiliaria.Data.Response
{
    public class ClienteResponse
        
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Cedula { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string Telefono { get; set; } = null!;

        public ClienteRequest ToRequest()
        {
            return new ClienteRequest
            {
                Id = Id,
                Nombre = Nombre,
                Cedula = Cedula,
                Telefono = Telefono,
                Direccion = Direccion
            };
        }


    }
}
