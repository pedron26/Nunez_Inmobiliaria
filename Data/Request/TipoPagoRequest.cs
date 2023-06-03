namespace Nuñez_Inmobiliaria.Data.Request
{
    public class TipoPagoRequest
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public ICollection<AlquilerRequest>? Alquileres { get; set; }
    }
}
