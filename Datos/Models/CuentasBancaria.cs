using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class CuentasBancaria
    {
        public string Cuenta { get; set; }
        public long CodigoBanco { get; set; }
        public string TipoCuenta { get; set; }
        public string NombreCuenta { get; set; }
        public double SaldoInicial { get; set; }
        public string CuentaContable { get; set; }
        public int ChequeInicial { get; set; }
        public int ChequeFinal { get; set; }
        public int CodMoneda { get; set; }
        public int IdCuentaBancaria { get; set; }
        public string NombreCuentaContable { get; set; }
        public DateTime Fecha { get; set; }
    }
}
