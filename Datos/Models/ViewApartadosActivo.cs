using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewApartadosActivo
    {
        public string BaseDatos { get; set; }
        public long Apartado { get; set; }
        public string Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public double Total { get; set; }
        public double? Saldo { get; set; }
    }
}
