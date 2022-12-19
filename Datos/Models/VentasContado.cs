using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class VentasContado
    {
        public double NumFactura { get; set; }
        public double Total { get; set; }
        public long NumApertura { get; set; }
        public bool Anulado { get; set; }
        public string Tipo { get; set; }
        public int CodMoneda { get; set; }
        public string NombreCliente { get; set; }
        public DateTime Fecha { get; set; }
    }
}
