using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class CierreCajaDetMon
    {
        public int IdDetaMoneda { get; set; }
        public int IdCierreCaja { get; set; }
        public int IdMoneda { get; set; }
        public double MontoSistema { get; set; }
        public double MontoCajero { get; set; }

        public virtual Cierrecaja IdCierreCajaNavigation { get; set; }
    }
}
