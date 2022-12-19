using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Area
    {
        public Area()
        {
            AreaArticulos = new HashSet<AreaArticulo>();
            AreaEncargados = new HashSet<AreaEncargado>();
        }

        public decimal IdArea { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }
        public int IdSucursal { get; set; }

        public virtual ICollection<AreaArticulo> AreaArticulos { get; set; }
        public virtual ICollection<AreaEncargado> AreaEncargados { get; set; }
    }
}
