using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ChequesDetalle
    {
        public long IdCheque { get; set; }
        public double Monto { get; set; }
        public string NombreCuenta { get; set; }
        public int CodMoneda { get; set; }
    }
}
