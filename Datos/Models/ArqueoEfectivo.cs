using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ArqueoEfectivo
    {
        public int Id { get; set; }
        public long IdArqueo { get; set; }
        public long IdDenominacion { get; set; }
        public double Monto { get; set; }
        public int Cantidad { get; set; }

        public virtual ArqueoCaja IdArqueoNavigation { get; set; }
    }
}
