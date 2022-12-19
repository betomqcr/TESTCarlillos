using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ArticulosGasto
    {
        public long IdArticuloComprados { get; set; }
        public long IdCompra { get; set; }
        public string Descripcion { get; set; }
        public double Base { get; set; }
        public double MontoFlete { get; set; }
        public double OtrosCargos { get; set; }
        public double Costo { get; set; }
        public double Cantidad { get; set; }
        public double Gravado { get; set; }
        public double Exento { get; set; }
        public double DescuentoP { get; set; }
        public double Descuento { get; set; }
        public double ImpuestoP { get; set; }
        public double Impuesto { get; set; }
        public double Total { get; set; }
        public double Devoluciones { get; set; }
        public double NuevoCostoBase { get; set; }
        public string CuentaContable { get; set; }
        public int CodTipoCompra { get; set; }
        public string DescTipoCompra { get; set; }

        public virtual Compra IdCompraNavigation { get; set; }
    }
}
