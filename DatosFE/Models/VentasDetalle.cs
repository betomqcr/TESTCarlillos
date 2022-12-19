using System;
using System.Collections.Generic;

#nullable disable

namespace DatosFE.Models
{
    public partial class VentasDetalle
    {
        public long IdVentaDetalle { get; set; }
        public long IdFactura { get; set; }
        public long Codigo { get; set; }
        public string CodArticulo { get; set; }
        public string Descripcion { get; set; }
        public double Cantidad { get; set; }
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
        public double Devoluciones { get; set; }
        public double NumeroEntrega { get; set; }
        public double MaxDescuento { get; set; }
        public double TipoCambioValorCompra { get; set; }
        public int CodMonedaVenta { get; set; }
        public string Lote { get; set; }
        public double CantVet { get; set; }
        public double CantBod { get; set; }
        public double? Disminuye { get; set; }
        public bool? Empaquetado { get; set; }
        public string NotaPantalla { get; set; }
        public long? IdBodega { get; set; }
        public double? Regalias { get; set; }
        public double? CostoReal { get; set; }
        public decimal IdTipoExoneracion { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime? FechaEmision { get; set; }
        public double PorcentajeCompra { get; set; }
        public decimal IdImpuesto { get; set; }
        public bool? Entregado { get; set; }
        public decimal Entregados { get; set; }
        public decimal IdSerie { get; set; }

        public virtual Inventario CodigoNavigation { get; set; }
        public virtual Venta IdFacturaNavigation { get; set; }
    }
}
