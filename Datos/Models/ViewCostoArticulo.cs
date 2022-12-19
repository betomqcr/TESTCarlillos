using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewCostoArticulo
    {
        public long Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Presentacion { get; set; }
        public double? Costo { get; set; }
        public double PrecioVenta { get; set; }
    }
}
