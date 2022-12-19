using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class PreTomaProveedor
    {
        public PreTomaProveedor()
        {
            PreTomaProveedorDetalles = new HashSet<PreTomaProveedorDetalle>();
        }

        public decimal Id { get; set; }
        public string IdUsuarioCreo { get; set; }
        public decimal CodigoProv { get; set; }
        public DateTime Fecha { get; set; }
        public bool Anulado { get; set; }
        public bool Usado { get; set; }

        public virtual ICollection<PreTomaProveedorDetalle> PreTomaProveedorDetalles { get; set; }
    }
}
