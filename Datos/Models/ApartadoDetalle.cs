using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ApartadoDetalle
    {
        public long IdDetalle { get; set; }
        public long IdApartado { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public double PrecioCosto { get; set; }
        public double PrecioBase { get; set; }
        public double PrecioFlete { get; set; }
        public double PrecioOtros { get; set; }
        public double PrecioUnit { get; set; }
        public double Impuesto { get; set; }
        public double MontoImpuesto { get; set; }
        public double SubtotalGravado { get; set; }
        public double SubTotalExcento { get; set; }
        public double SubTotal { get; set; }
        public double MontoDescuento { get; set; }
        public double Descuento { get; set; }
        public double MaxDescuento { get; set; }
        public double TipoCambioValorCompra { get; set; }
        public int CodMonedaVenta { get; set; }
        public long IdBodega { get; set; }
        public string CodArticulo { get; set; }

        public virtual Apartado IdApartadoNavigation { get; set; }
    }
}
