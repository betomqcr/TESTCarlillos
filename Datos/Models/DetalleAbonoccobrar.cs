using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class DetalleAbonoccobrar
    {
        public long Consecutivo { get; set; }
        public long IdRecibo { get; set; }
        public double Factura { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public double Monto { get; set; }
        public double SaldoAnt { get; set; }
        public double Intereses { get; set; }
        public double Abono { get; set; }
        public double AbonoSuMoneda { get; set; }
        public double Saldo { get; set; }

        public virtual Abonoccobrar IdReciboNavigation { get; set; }
    }
}
