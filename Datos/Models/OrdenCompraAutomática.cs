using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class OrdenCompraAutomática
    {
        public int CodigoProveedor { get; set; }
        public string Nombre { get; set; }
        public int Id { get; set; }
        public int Orden { get; set; }
        public long Codigo { get; set; }
        public string Descripcion { get; set; }
        public double CostoUnitario { get; set; }
        public double Cantidad { get; set; }
        public int TotalCompra { get; set; }
        public int PorcDescuento { get; set; }
        public int Descuento { get; set; }
        public double PorcImpuesto { get; set; }
        public int Impuesto { get; set; }
        public int OtrosCargos { get; set; }
        public int MontoFlete { get; set; }
        public double Costo { get; set; }
        public int Gravado { get; set; }
        public int Excento { get; set; }
    }
}
