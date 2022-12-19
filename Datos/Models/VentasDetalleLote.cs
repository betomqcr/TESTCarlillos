using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class VentasDetalleLote
    {
        public decimal IdVentaDetalleLote { get; set; }
        public decimal IdVentaDetalle { get; set; }
        public decimal IdLote { get; set; }
        public double Cantidad { get; set; }
    }
}
