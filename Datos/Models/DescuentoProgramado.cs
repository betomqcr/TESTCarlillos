using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class DescuentoProgramado
    {
        public decimal Id { get; set; }
        public decimal CodProveedor { get; set; }
        public double Porcentaje { get; set; }
    }
}
