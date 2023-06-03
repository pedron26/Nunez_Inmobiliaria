namespace Nuñez_Inmobiliaria.Data.Request
{
    public class PagoRequest
    {
        public int Id { get; set; }
        public int AlquilerId { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public AlquilerRequest? Alquiler { get; set; }
    }
}
