using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewRecibosContadoFirmado
    {
        public decimal Recibo { get; set; }
        public DateTime? Fecha { get; set; }
        public double Factura { get; set; }
        public string Tipo { get; set; }
        public string Cliente { get; set; }
        public double Total { get; set; }
    }
}
