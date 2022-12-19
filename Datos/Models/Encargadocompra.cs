using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Encargadocompra
    {
        public string Identificacion { get; set; }
        public long Cliente { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        public virtual Cliente ClienteNavigation { get; set; }
    }
}
