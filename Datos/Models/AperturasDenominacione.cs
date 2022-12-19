using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class AperturasDenominacione
    {
        public int IdApertura { get; set; }
        public double Cantidad { get; set; }
        public int Denominacion { get; set; }
        public double Monto { get; set; }
        public string MonedaNombre { get; set; }
        public string Tipo { get; set; }
    }
}
