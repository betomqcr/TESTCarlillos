using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class AperturaDenominacione
    {
        public long Id { get; set; }
        public int IdApertura { get; set; }
        public long IdDenominacion { get; set; }
        public double Monto { get; set; }
        public double Cantidad { get; set; }

        public virtual Aperturacaja IdAperturaNavigation { get; set; }
    }
}
