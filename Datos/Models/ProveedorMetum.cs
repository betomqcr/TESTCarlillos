using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ProveedorMetum
    {
        public decimal IdProveedorMeta { get; set; }
        public decimal? Codigoprov { get; set; }
        public double? Mensual { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal? Anulado { get; set; }
    }
}
