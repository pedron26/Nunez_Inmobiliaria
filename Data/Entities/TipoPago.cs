
// Entidad TipoPago
using System.ComponentModel.DataAnnotations;

public class TipoPago
{
    [Key]
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public ICollection<Alquiler>? Alquileres { get; set; }
}
