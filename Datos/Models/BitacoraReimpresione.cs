using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class BitacoraReimpresione
    {
        public long Id { get; set; }
        public string Usuario { get; set; }
        public string Cedula { get; set; }
        public DateTime Fecha { get; set; }
        public long Factura { get; set; }
        public string Motivo { get; set; }
    }
}
