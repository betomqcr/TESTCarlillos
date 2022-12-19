using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class TomaProveedorDetalle
    {
        public decimal Id { get; set; }
        public decimal IdTomaProveedor { get; set; }
        public decimal Codigo { get; set; }
        public string CodArticulo { get; set; }
        public string Descripicon { get; set; }
        public double Existencia { get; set; }
        public double Toma { get; set; }
        public double Diferencia { get; set; }

        public virtual TomaProveedor IdTomaProveedorNavigation { get; set; }
    }
}
