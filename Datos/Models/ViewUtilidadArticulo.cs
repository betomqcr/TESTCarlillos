using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewUtilidadArticulo
    {
        public long Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Presentacion { get; set; }
        public double? Costo { get; set; }
        public double PrecioVenta { get; set; }
        public double? Utilidad { get; set; }
    }
}
