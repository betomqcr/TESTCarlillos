using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class DevolucionPrestamo
    {
        public long Id { get; set; }
        public long IdDetallePrestamo { get; set; }
        public long IdPrestamo { get; set; }
        public long Codigo { get; set; }
        public string Descripcion { get; set; }
        public double Cantidad { get; set; }
        public DateTime Fecha { get; set; }
        public bool Anulado { get; set; }
    }
}
