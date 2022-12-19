using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ArticulosXProveedor
    {
        public long CodigoArticulo { get; set; }
        public int CodigoProveedor { get; set; }
        public DateTime FechaUltimaCompra { get; set; }
        public double UltimoCosto { get; set; }
        public int Moneda { get; set; }
        public bool ProveedorActual { get; set; }
    }
}
