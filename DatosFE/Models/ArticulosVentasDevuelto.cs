using System;
using System.Collections.Generic;

#nullable disable

namespace DatosFE.Models
{
    public partial class ArticulosVentasDevuelto
    {
        public long Consecutivo { get; set; }
        public long Devolucion { get; set; }
        public long Codigo { get; set; }
        public string Descripcion { get; set; }
        public double Cantidad { get; set; }
        public double CantVet { get; set; }
        public double CantBod { get; set; }
        public double PrecioCosto { get; set; }
        public double PrecioBase { get; set; }
        public double PrecioFlete { get; set; }
        public double PrecioOtros { get; set; }
        public double PrecioUnit { get; set; }
        public double Descuento { get; set; }
        public double MontoDescuento { get; set; }
        public double Impuesto { get; set; }
        public double MontoImpuesto { get; set; }
        public double SubtotalGravado { get; set; }
        public double SubTotalExcento { get; set; }
        public double SubTotal { get; set; }
        public int IdArtVenta { get; set; }
        public string IdArticuloV { get; set; }
        public bool? Devuelto { get; set; }
        public bool Empaquetado { get; set; }
        public bool Recibido { get; set; }

        public virtual Inventario CodigoNavigation { get; set; }
        public virtual DevolucionesVenta DevolucionNavigation { get; set; }
    }
}
