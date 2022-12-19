using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class OrdenTrabajo
    {
        public decimal IdOrden { get; set; }
        public string IdUsuario { get; set; }
        public DateTime FechaIngreso { get; set; }
        public decimal Serie { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Estado { get; set; }
        public string Observaciones { get; set; }
        public string TrabajoSolicitados { get; set; }
    }
}
