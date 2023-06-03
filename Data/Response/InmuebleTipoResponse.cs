namespace Nuñez_Inmobiliaria.Data.Response
{
    public class InmuebleTipoResponse
    {
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public ICollection<InmuebleResponse>? Inmuebles { get; set; }
    }

}
