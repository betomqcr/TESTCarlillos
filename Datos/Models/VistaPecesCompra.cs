using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class VistaPecesCompra
    {
        public long IdCompra { get; set; }
        public double Factura { get; set; }
        public double TotalFactura { get; set; }
        public DateTime Fecha { get; set; }
        public bool FacturaCancelado { get; set; }
        public long IdCompra1 { get; set; }
        public long Codigo { get; set; }
        public string CodArticulo { get; set; }
        public string Descripcion { get; set; }
        public double Cantidad { get; set; }
        public double Costo { get; set; }
        public double Total { get; set; }
        public bool? Peces { get; set; }
        public double PrecioA { get; set; }
        public double NuevoCostoBase { get; set; }
    }
}
