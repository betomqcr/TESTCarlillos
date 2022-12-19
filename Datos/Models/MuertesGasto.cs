using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class MuertesGasto
    {
        public long Consecutivo { get; set; }
        public DateTime Fecha { get; set; }
        public bool Anula { get; set; }
        public string Cedula { get; set; }
        public double TotalEntrada { get; set; }
        public double TotalSalida { get; set; }
        public double SaldoAjuste { get; set; }
        public double? Asiento { get; set; }
        public bool? Contabilizado { get; set; }
    }
}
