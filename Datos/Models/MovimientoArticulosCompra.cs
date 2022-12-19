using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class MovimientoArticulosCompra
    {
        public double Factura { get; set; }
        public string TipoCompra { get; set; }
        public string Nombre { get; set; }
        public DateTime? Fecha { get; set; }
        public long Codigo { get; set; }
        public string CodArticulo { get; set; }
        public double Cantidad { get; set; }
        public double Total { get; set; }
        public long IdCompra { get; set; }
    }
}
