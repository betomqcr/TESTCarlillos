using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class PerfilXUsuario
    {
        public int IdPerfil { get; set; }
        public string IdUsuario { get; set; }
        public int IdPerUser { get; set; }

        public virtual Perfil IdPerfilNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
