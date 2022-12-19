using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Codigo
    {
        public decimal Id { get; set; }
        public decimal IdPuntoVenta1 { get; set; }
        public decimal Codigo1 { get; set; }
        public string CodAlterno1 { get; set; }
        public string Descripcion1 { get; set; }
        public decimal IdPuntoVenta2 { get; set; }
        public decimal Codigo2 { get; set; }
        public string CodAlterno2 { get; set; }
        public string Descripcion2 { get; set; }
    }
}
