using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Ubicacione
    {
        public Ubicacione()
        {
            SubUbicacions = new HashSet<SubUbicacion>();
        }

        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }
        public bool? Activa { get; set; }

        public virtual ICollection<SubUbicacion> SubUbicacions { get; set; }
    }
}
