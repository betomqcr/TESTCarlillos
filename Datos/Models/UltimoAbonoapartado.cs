using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class UltimoAbonoapartado
    {
        public long IdAbonoapartado { get; set; }
        public DateTime Fecha { get; set; }
        public long Apartado { get; set; }
    }
}
