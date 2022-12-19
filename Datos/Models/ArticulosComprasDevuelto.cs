using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ArticulosComprasDevuelto
    {
        public long Consecutivo { get; set; }
        public long Devolucion { get; set; }
        public long Codigo { get; set; }
        public string Descripcion { get; set; }
        public double Cantidad { get; set; }
        public double PrecioCosto { get; set; }
        public double PrecioBase { get; set; }
        public double PrecioFlete { get; set; }
        public double PrecioOtros { get; set; }
        public double Descuento { get; set; }
        public double MontoDescuento { get; set; }
        public double Impuesto { get; set; }
        public double MontoImpuesto { get; set; }
        public double SubtotalGravado { get; set; }
        public double SubTotalExcento { get; set; }
        public double SubTotal { get; set; }
        public string Numero { get; set; }
        public int IdSucursal { get; set; }

        public virtual DevolucionesCompra DevolucionNavigation { get; set; }
    }
}
