using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class SubFamilia
    {
        public int CodigoFamilia { get; set; }
        public int SubCodigo { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

        public virtual Familium CodigoFamiliaNavigation { get; set; }
    }
}
