using System;

namespace Modelo
{
    public class cuentas_bancarias
    {
        public string Cuenta { get; set; }
        public long Codigo_banco { get; set; }
        public string tipoCuenta { get; set; }
        public string NombreCuenta { get; set; }
        public decimal SaldoInicial { get; set; }
        public string CuentaContable { get; set; }
        public int ChequeInicial { get; set; }
        public int ChequeFinal { get; set; }
        public int Cod_Moneda { get; set; }
        public int Id_CuentaBancaria { get; set; }
        public string NombreCuentaContable { get; set; }
        public DateTime Fecha { get; set; }
    }
}

