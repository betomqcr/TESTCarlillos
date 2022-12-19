using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class VistaKardexMovimiento
    {
        public long Codigo { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public int? Dias { get; set; }
    }
}
