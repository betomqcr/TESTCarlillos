using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class AreaArticulo
    {
        public decimal IdAreaArticulo { get; set; }
        public decimal IdArea { get; set; }
        public decimal Codigo { get; set; }

        public virtual Area IdAreaNavigation { get; set; }
    }
}
