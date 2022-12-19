using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class DetalleAbonocpagar
    {
        public int IdDetalleAbonocpagar { get; set; }
        public double Factura { get; set; }
        public int CodProveedor { get; set; }
        public double MontoFactura { get; set; }
        public double SaldoAnt { get; set; }
        public double Abono { get; set; }
        public double AbonoSuMoneda { get; set; }
        public double SaldoActual { get; set; }
        public long IdAbonocpagar { get; set; }
        public double IdCompra { get; set; }

        public virtual Abonocpagar IdAbonocpagarNavigation { get; set; }
    }
}
