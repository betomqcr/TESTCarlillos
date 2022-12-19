using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewSubtotalesDevolucione
    {
        public long Devolucion { get; set; }
        public double? TotalServiciosExento { get; set; }
        public double? TotalServiciosGravado { get; set; }
        public double? TotalMercaderiaExento { get; set; }
        public double? TotalMercaderiaGravado { get; set; }
        public double? TotalExento { get; set; }
        public double? TotalGravado { get; set; }
        public double? Total { get; set; }
        public double? TotalDescuento { get; set; }
        public double? TotalVentaNeta { get; set; }
        public double? TotalImpuesto { get; set; }
        public double? TotalComprobante { get; set; }
    }
}
