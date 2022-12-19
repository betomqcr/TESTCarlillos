using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewAbonosIncobrable
    {
        public string Db { get; set; }
        public long NumRecibo { get; set; }
        public string NombreCliente { get; set; }
        public DateTime FechaRecibo { get; set; }
        public string Observaciones { get; set; }
        public double Factura { get; set; }
        public double SaldoAnt { get; set; }
        public double Abono { get; set; }
        public double Intereses { get; set; }
        public double Saldo { get; set; }
    }
}
