namespace Modelo
{
    public class abonocpagar
    {
        public long Id_Abonocpagar { get; set; }
        public long Documento { get; set; }
        public string TipoDocumento { get; set; }
        public string CuentaBancaria { get; set; }
        public long Codigo_banco { get; set; }
        public decimal Saldo_Cuenta { get; set; }
        public decimal Monto { get; set; }
        public decimal Saldo_Actual { get; set; }
        //public DateTime Fecha { get; set; }
        public bool Contabilizado { get; set; }
        public string Recibo { get; set; }
        public string Cedula_Usuario { get; set; }
        public int Cod_Proveedor { get; set; }
        public bool Anulado { get; set; }
        public int cod_Moneda { get; set; }
        public decimal TipoCambio { get; set; }
        public string MontoLetras { get; set; }
        public long CuentaDestino { get; set; }
        //public DateTime FechaEntrada { get; set; }
        public string Observaciones { get; set; }
    }
}
