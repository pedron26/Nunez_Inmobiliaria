using Nuñez_Inmobiliaria.Data.Request;

namespace Nuñez_Inmobiliaria.Data.Response
{
    public class InmuebleResponse
    {
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public int InmuebleTipoId { get; set; }
        public string? Direccion { get; set; }
        public decimal PrecioAlquiler { get; set; }
        public InmuebleTipoResponse? InmuebleTipo { get; set; }

        public InmuebleRequest ToRequest()
        {
            return new InmuebleRequest
            {
                Id = Id,
                Descripcion = Descripcion,
                InmuebleTipoId = InmuebleTipoId,
                Direccion = Direccion,
                PrecioAlquiler = PrecioAlquiler,

            };

} }     } 
