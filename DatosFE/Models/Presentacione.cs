using System;
using System.Collections.Generic;

#nullable disable

namespace DatosFE.Models
{
    public partial class Presentacione
    {
        public Presentacione()
        {
            Inventarios = new HashSet<Inventario>();
        }

        public string Presentaciones { get; set; }
        public int CodPres { get; set; }
        public string Mh { get; set; }

        public virtual ICollection<Inventario> Inventarios { get; set; }
    }
}
