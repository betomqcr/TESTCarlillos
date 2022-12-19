using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class AreaEncargado
    {
        public decimal IdAreaEncargado { get; set; }
        public decimal IdArea { get; set; }
        public string IdUsuario { get; set; }

        public virtual Area IdAreaNavigation { get; set; }
    }
}
