using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class BitacoraVersion
    {
        public decimal Id { get; set; }
        public string IdUsuario { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public string Pc { get; set; }
    }
}
