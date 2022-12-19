using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Referenciacomercial
    {
        public long Cliente { get; set; }
        public string Empresa { get; set; }
        public string Telefono { get; set; }
        public double Monto { get; set; }
        public long Id { get; set; }

        public virtual Cliente ClienteNavigation { get; set; }
    }
}
