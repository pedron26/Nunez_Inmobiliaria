using Nuñez_Inmobiliaria.Data.Entities;

namespace Nuñez_Inmobiliaria.Data.Request
{
    public class AlquilerRequest
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int InmuebleId { get; set; }
        public int TipoPagoId { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaCulminacion { get; set; }
        public DateTime FechaDePago { get; set; }
    }
}
