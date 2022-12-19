using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class TomaGeneralDetalle
    {
        public decimal IdTomaDetalle { get; set; }
        public decimal IdToma { get; set; }
        public decimal Codigo { get; set; }
        public string CodArticulo { get; set; }
        public string Barras { get; set; }
        public string Descripcion { get; set; }
        public double Costo { get; set; }
        public double Existencia { get; set; }
        public double Toma { get; set; }
        public double Diferencia { get; set; }
        public bool Contado { get; set; }

        public virtual TomaGeneral IdTomaNavigation { get; set; }
    }
}
