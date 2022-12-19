using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class SubUbicacion
    {
        public int CodUbicacion { get; set; }
        public int CodSubUbicacion { get; set; }
        public string Codigo { get; set; }
        public string DescripcionD { get; set; }
        public string Observaciones { get; set; }

        public virtual Ubicacione CodUbicacionNavigation { get; set; }
    }
}
