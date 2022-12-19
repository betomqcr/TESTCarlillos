using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ArqueoTarjetum
    {
        public int Id { get; set; }
        public long IdArqueo { get; set; }
        public int IdTarjeta { get; set; }
        public double Monto { get; set; }

        public virtual ArqueoCaja IdArqueoNavigation { get; set; }
    }
}
