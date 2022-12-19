using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class PerfilXModulo
    {
        public int IdModuloPerfil { get; set; }
        public int IdPerfil { get; set; }
        public int IdModulo { get; set; }
        public bool AccionEjecucion { get; set; }
        public bool AccionActualizacion { get; set; }
        public bool AccionEliminacion { get; set; }
        public bool AccionBusqueda { get; set; }
        public bool AccionImpresion { get; set; }
        public bool AccionOpcion { get; set; }
        public string Menu { get; set; }

        public virtual Modulo IdModuloNavigation { get; set; }
        public virtual Perfil IdPerfilNavigation { get; set; }
    }
}
