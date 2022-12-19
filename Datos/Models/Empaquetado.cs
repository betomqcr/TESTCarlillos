using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Empaquetado
    {
        public long Id { get; set; }
        public long IdVentaDetalle { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public DateTime Fecha { get; set; }
        public string Timer { get; set; }
        public long? Factura { get; set; }
        public string Tipo { get; set; }
    }
}
