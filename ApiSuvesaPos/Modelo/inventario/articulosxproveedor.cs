using System;

namespace Modelo
{
    public class articulosxproveedor
    {
        public int CodigoArticulo { get; set; }
        public int CodigoProveedor { get; set; }
        public DateTime FechaUltimaCompra { get; set; }
        public decimal UltimoCosto { get; set; }
        public int Moneda { get; set; }
        public bool ProveedorActual { get; set; }
    }
}
