using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class PrecioDiferenciado
    {
        public decimal Id { get; set; }
        public decimal IdAgente { get; set; }
        public decimal CodProveedor { get; set; }
        public string Proveedor { get; set; }
        public string Tipo { get; set; }
        public double Porcentaje { get; set; }
    }
}
