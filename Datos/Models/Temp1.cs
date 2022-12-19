using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Temp1
    {
        public DateTime Fecha { get; set; }
        public long Consecutivo { get; set; }
        public long CodArticulo { get; set; }
        public string CodArticulo1 { get; set; }
        public string DescArticulo { get; set; }
        public double Cantidad { get; set; }
        public bool Entrada { get; set; }
    }
}
