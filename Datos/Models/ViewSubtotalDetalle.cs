using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewSubtotalDetalle
    {
        public long IdFactura { get; set; }
        public double? SubTotal { get; set; }
        public double? Descuento { get; set; }
    }
}
