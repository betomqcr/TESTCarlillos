using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Cheque
    {
        public long IdCheque { get; set; }
        public string Portador { get; set; }
        public DateTime Fecha { get; set; }
        public double Monto { get; set; }
        public bool Anulado { get; set; }
        public string Observaciones { get; set; }
        public string MontoLetras { get; set; }
        public string CedUsuario { get; set; }
        public string Facturas { get; set; }
    }
}
