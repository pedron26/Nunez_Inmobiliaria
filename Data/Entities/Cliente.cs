using Nuñez_Inmobiliaria.Data.Request;
using Nuñez_Inmobiliaria.Data.Response;
using System.ComponentModel.DataAnnotations;

namespace Nuñez_Inmobiliaria.Data.Entities

//  Entidad Cliente
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Cedula { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string Telefono { get; set; } = null!;

        internal static Cliente Crear(ClienteRequest cliente)
        {
            throw new NotImplementedException();
        }

        internal bool Modificar(ClienteRequest request)
        {
            throw new NotImplementedException();
        }

        internal ClienteResponse ToResponse()
            => new()
            {
                Id = Id,
                Nombre = Nombre,
                Cedula = Cedula,

                Telefono = Telefono,
                Direccion = Direccion
            };

    }
}