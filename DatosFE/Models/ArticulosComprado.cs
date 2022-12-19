using System;
using System.Collections.Generic;

#nullable disable

namespace DatosFE.Models
{
    public partial class ArticulosComprado
    {
        public long IdArticuloComprados { get; set; }
        public long IdCompra { get; set; }
        public long Codigo { get; set; }
        public string CodArticulo { get; set; }
        public string Descripcion { get; set; }
        public double Base { get; set; }
        public double MontoFlete { get; set; }
        public double OtrosCargos { get; set; }
        public double Costo { get; set; }
        public double Cantidad { get; set; }
        public double Regalias { get; set; }
        public double Gravado { get; set; }
        public double Exento { get; set; }
        public double DescuentoP { get; set; }
        public double Descuento { get; set; }
        public double ImpuestoP { get; set; }
        public double Impuesto { get; set; }
        public double Total { get; set; }
        public double Devoluciones { get; set; }
        public double PrecioA { get; set; }
        public double PrecioB { get; set; }
        public double PrecioC { get; set; }
        public double PrecioD { get; set; }
        public int CodMonedaVenta { get; set; }
        public double NuevoCostoBase { get; set; }
        public string Lote { get; set; }
        public bool Bonificado { get; set; }
        public long CodigoBonificado { get; set; }
        public double CantidadBonificado { get; set; }
        public double CostoBonificado { get; set; }
        public double SubTotalBonificado { get; set; }
        public string CodArticuloBonificacion { get; set; }
        public string CodCabys { get; set; }

        public virtual Inventario CodigoNavigation { get; set; }
        public virtual Compra IdCompraNavigation { get; set; }
    }
}
