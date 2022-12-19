using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class VentasUnificada
    {
        public string Localidad { get; set; }
        public DateTime Fecha { get; set; }
        public double NumFactura { get; set; }
        public string Tipo { get; set; }
        public long CodCliente { get; set; }
        public string NombreCliente { get; set; }
        public double SubTotal { get; set; }
        public double SubTotalGravada { get; set; }
        public double SubTotalExento { get; set; }
        public double Descuento { get; set; }
        public double ImpVenta { get; set; }
        public double Total { get; set; }
    }
}
