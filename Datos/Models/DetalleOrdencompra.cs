using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class DetalleOrdencompra
    {
        public long Id { get; set; }
        public long Orden { get; set; }
        public long Codigo { get; set; }
        public string Descripcion { get; set; }
        public double CostoUnitario { get; set; }
        public double Cantidad { get; set; }
        public double TotalCompra { get; set; }
        public double PorcDescuento { get; set; }
        public double Descuento { get; set; }
        public double PorcImpuesto { get; set; }
        public double Impuesto { get; set; }
        public double OtrosCargos { get; set; }
        public double MontoFlete { get; set; }
        public double Costo { get; set; }
        public double Gravado { get; set; }
        public double Exento { get; set; }
        public double Vendidos { get; set; }
        public double ExistActual { get; set; }

        public virtual Ordencompra OrdenNavigation { get; set; }
    }
}
