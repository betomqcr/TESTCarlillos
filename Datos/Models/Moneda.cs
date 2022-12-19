using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Moneda
    {
        public int CodMoneda { get; set; }

        public string MonedaNombre { get; set; }

        public double ValorCompra { get; set; }

        public double ValorVenta { get; set; }

        public string Simbolo { get; set; }

        public string CuentaContable { get; set; }

        public double Tccompra { get; set; }

        public bool Estado { get; set; }

        public string IdUsuarioCreacion { get; set; }

        public DateTime FechaCreacion { get; set; }

        public string IdUsuarioModificacion { get; set; }

        public Nullable<DateTime> FechaModificacion { get; set; }
    }
}
