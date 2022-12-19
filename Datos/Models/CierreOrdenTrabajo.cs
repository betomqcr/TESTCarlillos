using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class CierreOrdenTrabajo
    {
        public decimal IdCierre { get; set; }
        public decimal IdOrden { get; set; }
        public DateTime Fecha { get; set; }
        public string IdUsuario { get; set; }
        public string Observaciones { get; set; }
        public bool Anulado { get; set; }
    }
}
