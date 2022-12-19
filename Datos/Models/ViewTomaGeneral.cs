using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewTomaGeneral
    {
        public long Codigo { get; set; }
        public string CodArticulo { get; set; }
        public string Barras { get; set; }
        public string Descripcion { get; set; }
        public double Costo { get; set; }
        public double Existencia { get; set; }
        public int Toma { get; set; }
        public double Diferencia { get; set; }
        public bool? Contado { get; set; }
        public string SubUbicacion { get; set; }
    }
}
