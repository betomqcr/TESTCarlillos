using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class VistaOrdenCAutoXProveedor
    {
        public long Codigo { get; set; }
        public string Descripcion { get; set; }
        public double CostoUnitario { get; set; }
        public double ExistActual { get; set; }
        public double? Vendidos { get; set; }
        public double PorcImpuesto { get; set; }
        public double Costo { get; set; }
        public DateTime? Fecha { get; set; }
        public double Cantidad { get; set; }
        public bool Anulado { get; set; }
        public string SubUbicacion { get; set; }
        public int CodigoUbicacion { get; set; }
        public int MonedaCosto { get; set; }
        public int? Proveedor { get; set; }
    }
}
