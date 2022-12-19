using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewCajasBloqueada
    {
        public int Napertura { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombre { get; set; }
        public long NumCaja { get; set; }
        public bool? Bloqueada { get; set; }
    }
}
