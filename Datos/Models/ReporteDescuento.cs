using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ReporteDescuento
    {
        public long Id { get; set; }
        public double NumFactura { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public double Total { get; set; }
        public double Descuento { get; set; }
        public bool Anulado { get; set; }
        public long NumCaja { get; set; }
    }
}
