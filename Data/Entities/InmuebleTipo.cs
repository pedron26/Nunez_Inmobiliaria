using System.ComponentModel.DataAnnotations;

namespace Nuñez_Inmobiliaria.Data.Entities
{
    // Entidad InmuebleTipo
    public class InmuebleTipo
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public ICollection<Inmueble> Inmueble { get; set; } = null!;
    }
}