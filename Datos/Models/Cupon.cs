using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Cupon
    {
        public decimal IdCupon { get; set; }
        public decimal CantidadCupones { get; set; }
        public decimal Descuento { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public bool Anulado { get; set; }
    }
}
