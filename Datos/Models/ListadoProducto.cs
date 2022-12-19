using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ListadoProducto
    {
        public string Descripcion { get; set; }
        public string SubFamilia { get; set; }
        public string Expr1 { get; set; }
        public bool Inhabilitado { get; set; }
    }
}
