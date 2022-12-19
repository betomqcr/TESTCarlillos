using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Modulo
    {
        public Modulo()
        {
            PerfilXModulos = new HashSet<PerfilXModulo>();
        }

        public int IdModulo { get; set; }
        public string ModuloNombreInterno { get; set; }
        public string ModuloNombre { get; set; }
        public int Software { get; set; }
        public string Grupo { get; set; }

        public virtual ICollection<PerfilXModulo> PerfilXModulos { get; set; }
    }
}
