using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewFacturasPendientesPagada
    {
        public decimal IdApertura { get; set; }
        public decimal IdFactura { get; set; }
        public double NumFactura { get; set; }
        public string Tipo { get; set; }
        public string NombreCliente { get; set; }
        public double Total { get; set; }
        public DateTime Fecha { get; set; }
    }
}
