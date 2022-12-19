using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ReporteApartado
    {
        public long IdApartado { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombrecliente { get; set; }
        public double Total { get; set; }
        public string Nombre { get; set; }
        public double? Abonado { get; set; }
        public double? Saldo { get; set; }
        public DateTime Vence { get; set; }
        public bool Cancelado { get; set; }
    }
}
