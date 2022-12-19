using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class KardexPrestamo
    {
        public long Id { get; set; }
        public long? IdPrestamo { get; set; }
        public string Codigo { get; set; }
        public double? CantidadAnt { get; set; }
        public double? Cantidad { get; set; }
        public double? Actual { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
