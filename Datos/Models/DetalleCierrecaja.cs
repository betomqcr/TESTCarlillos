using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class DetalleCierrecaja
    {
        public int Id { get; set; }
        public int NumCierre { get; set; }
        public string Moneda { get; set; }
        public double Efectivo { get; set; }
        public double Tarjeta { get; set; }
        public double Cheque { get; set; }
        public double Transferencia { get; set; }
        public double Devoluciones { get; set; }
        public double Total { get; set; }
    }
}
