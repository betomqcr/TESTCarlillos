using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewArea
    {
        public decimal IdArea { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }
        public decimal Codigo { get; set; }
        public string CodArticulo { get; set; }
        public string Barras { get; set; }
        public string Articulo { get; set; }
        public double Existencia { get; set; }
    }
}
