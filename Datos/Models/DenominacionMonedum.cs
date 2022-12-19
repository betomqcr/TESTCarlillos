using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class DenominacionMonedum
    {
        public long Id { get; set; }
        public int CodMoneda { get; set; }
        public int Denominacion { get; set; }
        public string Tipo { get; set; }
    }
}
