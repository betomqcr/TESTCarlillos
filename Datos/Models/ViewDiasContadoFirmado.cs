using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewDiasContadoFirmado
    {
        public DateTime? Fecha { get; set; }
        public int? Dias { get; set; }
        public string NombreRetira { get; set; }
        public string TelefonoRetira { get; set; }
        public double NumFactura { get; set; }
        public string NombreCliente { get; set; }
        public double? Total { get; set; }
        public decimal IdFactura { get; set; }
    }
}
