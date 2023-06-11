using Nuñez_Inmobiliaria.Data.Request;
using Nuñez_Inmobiliaria.Data.Response;
using System.ComponentModel.DataAnnotations;

namespace Nuñez_Inmobiliaria.Data.Entities
{
    // Entidad Inmueble
    public class Inmueble
    {
        [Key]
        public int Id { get; set; }
        public string? Descripcion { get; set; } 
        public int InmuebleTipoId { get; set; }
        public string? Direccion { get; set; } = null!;
        public decimal PrecioAlquiler { get; set; }
        public InmuebleTipo InmuebleTipo { get; set; } = null!;



        internal  static Inmueble Crear(InmuebleRequest inmueble)
        {
            // Lógica para crear un nuevo inmueble a partir de un objeto InmuebleRequest
            return new Inmueble
            {
                Descripcion = inmueble.Descripcion,
                InmuebleTipoId = inmueble.InmuebleTipoId,
                Direccion = inmueble.Direccion,
                PrecioAlquiler = inmueble.PrecioAlquiler
            };
        }

        internal  bool Modificar(InmuebleRequest request)
        {
            // Lógica para modificar las propiedades de un inmueble existente según un objeto InmuebleRequest
            
            if (!string.IsNullOrEmpty(request.Descripcion))
                Descripcion = request.Descripcion;

            if (request.InmuebleTipoId > 0)
                InmuebleTipoId = request.InmuebleTipoId;

            if (!string.IsNullOrEmpty(request.Direccion))
                Direccion = request.Direccion;

            if (request.PrecioAlquiler > 0)
                PrecioAlquiler = request.PrecioAlquiler;

            return true; 
        }

        public InmuebleResponse ToResponse()
        {
           
            return new InmuebleResponse
            {
                Id = Id,
                Descripcion = Descripcion,
                InmuebleTipoId = InmuebleTipoId,
                Direccion = Direccion,
                PrecioAlquiler = PrecioAlquiler
            };
        }


    }

}