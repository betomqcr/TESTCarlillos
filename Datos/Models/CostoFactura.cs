using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class CostoFactura
    {
        public long IdFactura { get; set; }
        public double? CostoVenta { get; set; }
    }
}
