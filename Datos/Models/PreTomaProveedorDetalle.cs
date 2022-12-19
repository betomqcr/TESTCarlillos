using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class PreTomaProveedorDetalle
    {
        public decimal Id { get; set; }
        public decimal IdPreTomaProveedor { get; set; }
        public decimal Codigo { get; set; }
        public string CodArticulo { get; set; }
        public string Descripicon { get; set; }
        public double Cantidad { get; set; }

        public virtual PreTomaProveedor IdPreTomaProveedorNavigation { get; set; }
    }
}
