using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class DetalleAjustescPagar
    {
        public long IdDetalleAjustecPagar { get; set; }
        public long IdAjustecPagar { get; set; }
        public double Factura { get; set; }
        public string Tipo { get; set; }
        public double Monto { get; set; }
        public double SaldoAnt { get; set; }
        public double Ajuste { get; set; }
        public double AjusteSuMoneda { get; set; }
        public double SaldoAjustado { get; set; }
        public string Observaciones { get; set; }
        public string TipoNota { get; set; }
        public long IdCompra { get; set; }
        public string CuentaContable { get; set; }
        public string DescripcionCuentaContable { get; set; }

        public virtual Ajustescpagar IdAjustecPagarNavigation { get; set; }
    }
}
