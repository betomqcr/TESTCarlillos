using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class RifaDetalle
    {
        public decimal IdRifaDetalle { get; set; }
        public decimal IdRifa { get; set; }
        public decimal IdProveedor { get; set; }
        public string Nombre { get; set; }
    }
}
