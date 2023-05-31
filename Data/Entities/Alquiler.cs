using Nuñez_Inmobiliaria.Data.Entities;
using System.ComponentModel.DataAnnotations;

// Entidad Alquiler
public class Alquiler
{
    [Key]
    public int Id { get; set; }
    public int ClienteId { get; set; }
    public int InmuebleId { get; set; }
    public int TipoPagoId { get; set; }
    public DateTime Fecha { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime FechaCulminacion { get; set; }
    public DateTime FechaDePago { get; set; }
    public Cliente Cliente { get; set; } = null!;
    public Inmueble Inmueble { get; set; } = null!;
    public TipoPago TipoPago { get; set; } = null!;
    public ICollection<Pago> Pagos { get; set; } = null!;
}