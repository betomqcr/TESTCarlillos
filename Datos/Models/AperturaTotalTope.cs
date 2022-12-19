using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class AperturaTotalTope
    {
        public int IdTotalTope { get; set; }
        public int Napertura { get; set; }
        public int CodMoneda { get; set; }
        public double MontoTope { get; set; }
        public string MonedaNombre { get; set; }

        public virtual Aperturacaja NaperturaNavigation { get; set; }
    }
}
