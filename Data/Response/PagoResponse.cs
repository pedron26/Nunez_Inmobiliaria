namespace Nuñez_Inmobiliaria.Data.Response
{
    public class PagoResponse
    {
        public int Id { get; set; }
        public int AlquilerId { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public AlquilerResponse? Alquiler { get; set; }
    }

}
