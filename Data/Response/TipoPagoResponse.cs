namespace Nuñez_Inmobiliaria.Data.Response
{
    public class TipoPagoResponse
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public ICollection<AlquilerResponse>? Alquileres { get; set; }
    }

}
