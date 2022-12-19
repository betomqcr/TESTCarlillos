using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class CierreCajaDetTarj
    {
        public int IdDetalleTarjeta { get; set; }
        public int IdCierreCaja { get; set; }
        public int IdTipoTarjeta { get; set; }
        public double MontoSistema { get; set; }
        public double MontoCajero { get; set; }

        public virtual Cierrecaja IdCierreCajaNavigation { get; set; }
    }
}
