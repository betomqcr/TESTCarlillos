using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Abonoreintegro
    {
        public decimal IdAbono { get; set; }
        public decimal IdFactura { get; set; }
        public DateTime Fecha { get; set; }
        public double Monto { get; set; }
        public bool Anulado { get; set; }
        public decimal Recibo { get; set; }
        public decimal NumApertura { get; set; }
        public int IdSucursal { get; set; }
    }
}
