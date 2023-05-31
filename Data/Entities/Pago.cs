// Entidad Pago
using System.ComponentModel.DataAnnotations;

public class Pago
{
    [Key]
    public int Id { get; set; }
    public int AlquilerId { get; set; }
    public decimal Monto { get; set; }
    public DateTime Fecha { get; set; }
    public Alquiler Alquiler { get; set; } = null!;
}

