﻿namespace Nuñez_Inmobiliaria.Data.Request
{
    public class InmuebleRequest
    {
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public int InmuebleTipoId { get; set; }
        public string? Direccion { get; set; }
        public decimal PrecioAlquiler { get; set; }
        public InmuebleTipoRequest? InmuebleTipo { get; set; }
    }
}
