using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class CuponDetalle
    {
        public decimal IdCuponDetalle { get; set; }
        public string IdCupon { get; set; }
        public decimal Codigo { get; set; }
        public decimal IdFactura { get; set; }
    }
}
