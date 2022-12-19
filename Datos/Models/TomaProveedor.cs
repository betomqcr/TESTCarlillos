using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class TomaProveedor
    {
        public TomaProveedor()
        {
            TomaProveedorDetalles = new HashSet<TomaProveedorDetalle>();
        }

        public decimal Id { get; set; }
        public string IdUsuarioCreo { get; set; }
        public decimal CodigoProv { get; set; }
        public DateTime Fecha { get; set; }
        public bool Anulado { get; set; }
        public bool Aplicado { get; set; }

        public virtual ICollection<TomaProveedorDetalle> TomaProveedorDetalles { get; set; }
    }
}
