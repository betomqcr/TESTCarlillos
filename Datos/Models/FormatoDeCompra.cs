using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class FormatoDeCompra
    {
        public long Codigo { get; set; }
        public string Barras { get; set; }
        public string Descripcion { get; set; }
        public double? Cant { get; set; }
        public double? Costo { get; set; }
    }
}
