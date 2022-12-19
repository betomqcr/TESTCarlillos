using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewUltimaCompra
    {
        public long Codigo { get; set; }
        public string Descripcion { get; set; }
        public double Existencia { get; set; }
        public DateTime? UltimaFecha { get; set; }
    }
}
