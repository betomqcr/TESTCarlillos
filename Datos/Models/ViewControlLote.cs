using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewControlLote
    {
        public long Codigo { get; set; }
        public string CodArticulo { get; set; }
        public string Descripcion { get; set; }
        public string Lote { get; set; }
        public DateTime Vence { get; set; }
        public double Cantidad { get; set; }
        public double Actual { get; set; }
        public double Costo { get; set; }
        public double PrecioA { get; set; }
        public bool Consignacion { get; set; }
        public int IdBodega { get; set; }
    }
}
