using Nuñez_Inmobiliaria.Data.Request;

namespace Nuñez_Inmobiliaria.Data.Response
{
    public class AlquilerResponse
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int InmuebleId { get; set; }
        public int TipoPagoId { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaCulminacion { get; set; }
        public DateTime FechaDePago { get; set; }
        public ClienteResponse? Cliente { get; set; }
        public InmuebleResponse? Inmueble { get; set; }
        public TipoPagoResponse? TipoPago { get; set; }
        public ICollection<PagoResponse>? Pagos { get; set; }



        public AlquilerRequest ToRequest()
        {
            return new AlquilerRequest
            {
               Id = Id,
               ClienteId = ClienteId,
               InmuebleId = InmuebleId,
               TipoPagoId = TipoPagoId,
               Fecha = Fecha,
               FechaInicio = FechaInicio,
               FechaCulminacion = FechaCulminacion,
               FechaDePago  = FechaDePago,

            };
        }
    }

}
