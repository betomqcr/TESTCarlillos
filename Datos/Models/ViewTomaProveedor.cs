using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewTomaProveedor
    {
        public decimal Id { get; set; }
        public string IdUsuarioCreo { get; set; }
        public string Usuario { get; set; }
        public decimal CodigoProv { get; set; }
        public string Proveedor { get; set; }
        public DateTime Fecha { get; set; }
        public bool Anulado { get; set; }
        public bool Aplicado { get; set; }
    }
}
