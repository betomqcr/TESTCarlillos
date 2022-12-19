using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ArticulosProveedor
    {
        public decimal Id { get; set; }
        public string Cedula { get; set; }
        public string CodigoProveedor { get; set; }
        public decimal IdArticulo { get; set; }
        public decimal CantidadxPresentacion { get; set; }
    }
}
