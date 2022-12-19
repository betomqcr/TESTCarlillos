using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class HistoricoSerie
    {
        public decimal Id { get; set; }
        public decimal Boleta { get; set; }
        public decimal IdSerie { get; set; }
        public DateTime Fecha { get; set; }
        public string IdUsuario { get; set; }
        public string Observacion { get; set; }
    }
}
