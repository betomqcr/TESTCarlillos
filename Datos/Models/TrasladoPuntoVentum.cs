using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class TrasladoPuntoVentum
    {
        public decimal Id { get; set; }
        public DateTime Fecha { get; set; }
        public decimal IdPuntoVentaOrigen { get; set; }
        public decimal IdPuentoVentaDestino { get; set; }
        public string Observaciones { get; set; }
        public bool Anulado { get; set; }
        public string IdUsuarioCreo { get; set; }
    }
}
