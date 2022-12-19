using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class TipoExoneracion
    {
        public int IdTipoExoneracion { get; set; }
        public string Detalle { get; set; }
        public string Codigo { get; set; }
    }
}
