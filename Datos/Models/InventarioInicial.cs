using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class InventarioInicial
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public double? Actual { get; set; }
        public double? ExistenciaBodega { get; set; }
    }
}
