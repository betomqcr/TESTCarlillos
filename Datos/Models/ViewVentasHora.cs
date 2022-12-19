using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewVentasHora
    {
        public DateTime Fecha { get; set; }
        public DateTime? Dia { get; set; }
        public string Hora { get; set; }
        public double Total { get; set; }
        public int? NumeroDia { get; set; }
    }
}
