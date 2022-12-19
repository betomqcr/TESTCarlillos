using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ReporteGerencialInventario
    {
        public long Codigo { get; set; }
        public string Descripcion { get; set; }
        public double? Mes12 { get; set; }
        public double? Mes11 { get; set; }
        public double? Mes10 { get; set; }
        public double? Mes9 { get; set; }
        public double? Mes8 { get; set; }
        public double? Mes7 { get; set; }
        public double? Mes6 { get; set; }
        public double? Mes5 { get; set; }
        public double? Mes4 { get; set; }
        public double? Mes3 { get; set; }
        public double? Mes2 { get; set; }
        public double? Mes1 { get; set; }
        public double? MesActual { get; set; }
        public int CodPresentacion { get; set; }
        public double MaxDescuento { get; set; }
        public double Actual { get; set; }
        public double? PrecioVentaPromedio { get; set; }
        public int TotalVentas { get; set; }
        public int TotalCostos { get; set; }
        public string Ubicaciones { get; set; }
        public string Presentaciones { get; set; }
        public string Proveedores { get; set; }
    }
}
