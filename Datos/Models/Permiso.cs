using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Permiso
    {
        public long Id { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
    }
}
