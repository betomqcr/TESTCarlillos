using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class UltimoRecibo
    {
        public DateTime Fecha { get; set; }
        public double Factura { get; set; }
        public string Tipo { get; set; }
        public long IdRecibo { get; set; }
    }
}
