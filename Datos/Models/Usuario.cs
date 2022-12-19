using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Datos.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            PerfilXUsuarios = new HashSet<PerfilXUsuario>();
        }

        public string IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string ClaveEntrada { get; set; }
        public string ClaveInterna { get; set; }
        public int Perfil { get; set; }
        public byte[] Foto { get; set; }
        public string Iniciales { get; set; }
        public bool CambiarPrecio { get; set; }
        public double PorcPrecio { get; set; }
        public bool AplicarDesc { get; set; }
        public double PorcDesc { get; set; }
        public bool ExistNegativa { get; set; }

        [Required]
        [EmailAddress]

        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public string idUserAspNet { get; set; }


        public virtual ICollection<PerfilXUsuario> PerfilXUsuarios { get; set; }
    }
}
