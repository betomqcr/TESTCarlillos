using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class VwRegistroAjustesInventario
    {
        public string Nombre { get; set; }
        public string Administrador { get; set; }
        public long Consecutivo { get; set; }
        public string Cedula { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public bool Anula { get; set; }
        public string Expr1 { get; set; }
    }
}
