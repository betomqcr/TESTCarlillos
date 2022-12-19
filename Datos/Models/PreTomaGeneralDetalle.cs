using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class PreTomaGeneralDetalle
    {
        public decimal IdPreTomaDetalle { get; set; }
        public decimal IdPreToma { get; set; }
        public decimal Codigo { get; set; }
        public string CodArticulo { get; set; }
        public string Barras { get; set; }
        public string Descripcion { get; set; }
        public double Costo { get; set; }
        public double Existencia { get; set; }
        public double Toma { get; set; }
        public double Diferencia { get; set; }
        public bool Contado { get; set; }

        public virtual PreTomaGeneral IdPreTomaNavigation { get; set; }
    }
}
