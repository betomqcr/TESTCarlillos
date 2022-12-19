using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class MovimientoCuentaCliente
    {
        public long CodCliente { get; set; }
        public DateTime Fecha { get; set; }
        public double Factura { get; set; }
        public string TipoDoc { get; set; }
        public double Documento { get; set; }
        public double Acreditado { get; set; }
        public double? Debitado { get; set; }
        public int CodMoneda { get; set; }
    }
}
