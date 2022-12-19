using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewMovimientoSerie
    {
        public decimal Id { get; set; }
        public decimal Boleta { get; set; }
        public decimal IdSerie { get; set; }
        public string Serie { get; set; }
        public DateTime Fecha { get; set; }
        public string IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Observacion { get; set; }
    }
}
