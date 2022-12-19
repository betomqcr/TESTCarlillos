using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Descuento
    {
        public decimal IdDescuento { get; set; }
        public decimal IdProveedor { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public double Descuento1 { get; set; }
        public bool Confirmado { get; set; }
        public string ContactoConfirmo { get; set; }
    }
}
