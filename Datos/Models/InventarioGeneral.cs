using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class InventarioGeneral
    {
        public string CodArticulo { get; set; }
        public string Descripcion { get; set; }
        public double PresentaCant { get; set; }
        public string Presentaciones { get; set; }
        public double Existencia { get; set; }
        public double PrecioFinal { get; set; }
        public double? Prestamo { get; set; }
        public long Codigo { get; set; }
    }
}
