using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class BitacoraEstadoCotizacion
    {
        public decimal Id { get; set; }
        public decimal Cotizacion { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public string Observaciones { get; set; }
    }
}
