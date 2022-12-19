using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Sucursale
    {
        public Sucursale()
        {
            AjusteInventarios = new HashSet<AjusteInventario>();
        }

        public int Id { get; set; }
        public string NombreComercial { get; set; }
        public string NombreFiscal { get; set; }
        public int TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Alias { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public virtual ICollection<AjusteInventario> AjusteInventarios { get; set; }
    }
}
