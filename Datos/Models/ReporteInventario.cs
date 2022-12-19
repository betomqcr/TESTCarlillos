using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ReporteInventario
    {
        public long Codigo { get; set; }
        public string Descripcion { get; set; }
        public double Iventa { get; set; }
        public string Marca { get; set; }
        public string SubFamilia { get; set; }
        public string Ubicacion { get; set; }
        public double Utilidad { get; set; }
        public double Costo { get; set; }
        public double TcCompra { get; set; }
        public double PrecioA { get; set; }
        public double TcVenta { get; set; }
        public double ValorInventario { get; set; }
        public double CostoInventario { get; set; }
        public double GananciaInventario { get; set; }
        public double Minima { get; set; }
        public double Maxima { get; set; }
        public double Existencia { get; set; }
        public string Familia { get; set; }
    }
}
