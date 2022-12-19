namespace Modelo
{
    public class detalle_ajustesccobrar
    {
        public long Id_DetalleAjustecCobrar { get; set; }
        public long Id_AjustecCobrar { get; set; }
        public decimal Factura { get; set; }
        public char Tipo { get; set; }
        public decimal Monto { get; set; }
        public decimal Saldo_Ant { get; set; }
        public decimal Ajuste { get; set; }
        public decimal Ajuste_SuMoneda { get; set; }
        public decimal Saldo_Ajustado { get; set; }
        public string Observaciones { get; set; }
        public char TipoNota { get; set; }
        public string CuentaContable { get; set; }
        public int IdCuentaC { get; set; }
    }
}
