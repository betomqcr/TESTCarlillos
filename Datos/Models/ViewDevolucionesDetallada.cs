using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewDevolucionesDetallada
    {
        public long Devolucion { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public decimal CajaDevolucion { get; set; }
        public double MontoDevolucion { get; set; }
        public double MontoReintegro { get; set; }
        public string NotasDevolucion { get; set; }
        public double NumeroFactura { get; set; }
        public string TipoFactura { get; set; }
        public double MontoFactura { get; set; }
        public DateTime FechaFactura { get; set; }
        public string Cliente { get; set; }
        public string UsuarioFacturo { get; set; }
        public string UsuarioDevolvio { get; set; }
        public string UsuarioRecibio { get; set; }
    }
}
