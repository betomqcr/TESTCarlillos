using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Monedum
    {
        public int CodMoneda { get; set; }
        public string MonedaNombre { get; set; }
        public double ValorCompra { get; set; }
        public double ValorVenta { get; set; }
        public string Simbolo { get; set; }
        public string CuentaContable { get; set; }
        public double Tccompra { get; set; }
    }
}
