using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Empresa
    {
        public long Id { get; set; }
        public string Empresa1 { get; set; }
        public bool Actual { get; set; }
        public string Cedula { get; set; }
    }
}
