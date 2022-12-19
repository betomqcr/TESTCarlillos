using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewDepositosCaja
    {
        public DateTime Fecha { get; set; }
        public decimal IdApertura { get; set; }
        public string Usuario { get; set; }
        public string Banco { get; set; }
        public string Cuenta { get; set; }
        public string Moneda { get; set; }
        public string Numero { get; set; }
        public double Monto { get; set; }
    }
}
