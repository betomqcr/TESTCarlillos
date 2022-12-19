using System;

namespace Modelo
{
    public class bitacoraestadocotizacion
    {
        public int Id { get; set; }
        public int Cotizacion { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public string Observaciones { get; set; }
    }
}
