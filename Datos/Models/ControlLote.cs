using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ControlLote
    {
        public decimal Id { get; set; }
        public long IdReferencia { get; set; }
        public string Lote { get; set; }
        public DateTime Vence { get; set; }
        public long Codigo { get; set; }
        public string Barras { get; set; }
        public double Cantidad { get; set; }
        public double Actual { get; set; }
        public bool ImpresoGeneral { get; set; }
    }
}
