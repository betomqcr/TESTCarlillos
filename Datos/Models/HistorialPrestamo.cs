using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class HistorialPrestamo
    {
        public long Id { get; set; }
        public long IdPrestamo { get; set; }
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Accion { get; set; }
    }
}
