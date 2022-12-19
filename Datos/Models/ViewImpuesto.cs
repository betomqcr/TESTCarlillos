using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewImpuesto
    {
        public decimal IdImpuesto { get; set; }
        public string Impuesto { get; set; }
        public string CodigoImpuesto { get; set; }
        public string CodigoTarifa { get; set; }
        public double Porcentaje { get; set; }
        public string Simbolo { get; set; }
    }
}
