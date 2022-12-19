using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ArqueoDeposito
    {
        public decimal Id { get; set; }
        public long IdArqueo { get; set; }
        public string Banco { get; set; }
        public string Cuenta { get; set; }
        public string Moneda { get; set; }
        public string Numero { get; set; }
        public double Monto { get; set; }
        public decimal IdApertura { get; set; }
        public string Tipo { get; set; }

        public virtual ArqueoCaja IdArqueoNavigation { get; set; }
    }
}
