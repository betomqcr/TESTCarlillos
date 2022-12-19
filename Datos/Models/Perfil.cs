using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Perfil
    {
        public Perfil()
        {
            PerfilXModulos = new HashSet<PerfilXModulo>();
            PerfilXUsuarios = new HashSet<PerfilXUsuario>();
        }

        public int IdPerfil { get; set; }
        public string NombrePerfil { get; set; }

        public virtual ICollection<PerfilXModulo> PerfilXModulos { get; set; }
        public virtual ICollection<PerfilXUsuario> PerfilXUsuarios { get; set; }
    }
}
