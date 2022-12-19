using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewArticulosDescuento
    {
        public int IdProveedor { get; set; }
        public string Proveedor { get; set; }
        public string Factura { get; set; }
        public string Cliente { get; set; }
        public string Descripcion { get; set; }
        public double Cantidad { get; set; }
        public double Descuento { get; set; }
        public double MontoDescuento { get; set; }
        public DateTime Fecha { get; set; }
        public double SubTotal { get; set; }
    }
}
