using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewPedidosBodega
    {
        public decimal IdPedido { get; set; }
        public string Estado { get; set; }
        public string CodArticulo { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }
        public double CantidadSolicitud { get; set; }
        public double CantidadPedido { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public DateTime? FechaPedido { get; set; }
        public string Proveedor { get; set; }
        public string UsuarioSolicito { get; set; }
        public string CasaComercial { get; set; }
    }
}
