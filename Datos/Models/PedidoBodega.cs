using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class PedidoBodega
    {
        public decimal IdPedido { get; set; }
        public decimal Consecutivo { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public DateTime FechaPedido { get; set; }
        public string IdUsuarioSolicitud { get; set; }
        public decimal Codigo { get; set; }
        public double CantidadSolicitud { get; set; }
        public double CantidadPedido { get; set; }
        public decimal Proveedor { get; set; }
        public string Estado { get; set; }
        public string Observaciones { get; set; }
        public double PrecioUnid { get; set; }
        public double CantidadPuntos { get; set; }
        public string IdUsuarioPidio { get; set; }
        public string IdUsuarioRecibio { get; set; }
        public DateTime FechaRecibido { get; set; }
    }
}
