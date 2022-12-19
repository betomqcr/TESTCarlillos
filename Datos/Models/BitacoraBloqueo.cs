using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class BitacoraBloqueo
    {
        public decimal Id { get; set; }
        public DateTime? Ini { get; set; }
        public string Obs { get; set; }
        public string Usuario { get; set; }
    }
}
