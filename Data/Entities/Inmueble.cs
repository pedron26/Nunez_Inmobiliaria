using System.ComponentModel.DataAnnotations;

namespace Nuñez_Inmobiliaria.Data.Entities
{
    // Entidad Inmueble
    public class Inmueble
    {
        [Key]
        public int Id { get; set; }
        public string Descripcion { get; set; } = null!;
        public int InmuebleTipoId { get; set; }
        public string Direccion { get; set; } = null!;
        public decimal PrecioAlquiler { get; set; }
        public InmuebleTipo InmuebleTipo { get; set; } = null!;
    }
}