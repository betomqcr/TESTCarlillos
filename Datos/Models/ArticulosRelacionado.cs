using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ArticulosRelacionado
    {
        public decimal Id { get; set; }
        public decimal CodigoPrincipal { get; set; }
        public decimal Codigo { get; set; }
        public string CodArticulo { get; set; }
        public string Descripcion { get; set; }
        public double Cantidad { get; set; }
    }
}
