using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewImpresoGeneralLote
    {
        public decimal Id { get; set; }
        public DateTime Vence { get; set; }
        public string Lote { get; set; }
        public double Actual { get; set; }
        public string CodArticulo { get; set; }
        public string Descripcion { get; set; }
        public string Presentacion { get; set; }
        public string Barras { get; set; }
        public bool? Imprimir { get; set; }
    }
}
