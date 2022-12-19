using System;

namespace Modelo
{
    public class pedidobodega
    {
        public int IdPedido { get; set; }
        public int Consecutivo { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public DateTime FechaPedido { get; set; }
        public string IdUsuarioSolicitud { get; set; }
        public int Codigo { get; set; }
        public decimal CantidadSolicitud { get; set; }
        public decimal CantidadPedido { get; set; }
        public int Proveedor { get; set; }
        public string Estado { get; set; }
        public string Observaciones { get; set; }
        public decimal PrecioUnid { get; set; }
        public decimal CantidadPuntos { get; set; }
        public string IdUsuarioPidio { get; set; }
        public string IdUsuarioRecibio { get; set; }
        public DateTime FechaRecibido { get; set; }
    }
}
