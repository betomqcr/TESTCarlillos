using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Familium
    {
        public Familium()
        {
            SubFamilia = new HashSet<SubFamilia>();
        }

        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }
        public string CuentaGra { get; set; }
        public string DescripcionGra { get; set; }
        public string CuentaExe { get; set; }
        public string DescripcionExe { get; set; }
        public string CuentaCosto { get; set; }
        public string DescripcionCosto { get; set; }

        public virtual ICollection<SubFamilia> SubFamilia { get; set; }
    }
}
