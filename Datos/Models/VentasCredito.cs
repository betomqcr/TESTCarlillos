using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class VentasCredito
    {
        public string Expr1 { get; set; }
        public double SubTotal { get; set; }
        public double Total { get; set; }
        public double NumFactura { get; set; }
        public long NumApertura { get; set; }
        public long Id { get; set; }
        public int CodMoneda { get; set; }
        public string NombreCliente { get; set; }
        public DateTime Fecha { get; set; }
        public string CedulaUsuario { get; set; }
        public double TipoCambio { get; set; }
        public long CodCliente { get; set; }
    }
}
