using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Presentacione
    {
        //public Presentacione()
        //{
        //    Inventarios = new HashSet<Inventario>();
        //}

        public string Presentaciones { get; set; }

        public int CodPres { get; set; }

        public string Mh { get; set; }

        public bool Estado { get; set; }

        public string IdUsuarioCreacion { get; set; }

        public DateTime FechaCreacion { get; set; }

        public string IdUsuarioModificacion { get; set; }

        public Nullable<DateTime> FechaModificacion { get; set; }

        //public virtual ICollection<Inventario> Inventarios { get; set; }
    }
}
