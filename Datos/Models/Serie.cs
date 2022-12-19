using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Serie
    {
        public decimal Id { get; set; }
        public decimal Codigo { get; set; }
        public string Serie1 { get; set; }
        public bool Vendido { get; set; }
        public decimal Factura { get; set; }
    }
}
