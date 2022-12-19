namespace Modelo
{
    public class detalle_ajustescpagar
    {
        public long Id_DetalleAjustecPagar { get; set; }
        public long Id_AjustecPagar { get; set; }
        public decimal Factura { get; set; }
        public string Tipo { get; set; }
        public decimal Monto { get; set; }
        public decimal Saldo_Ant { get; set; }
        public decimal Ajuste { get; set; }
        public decimal Ajuste_SuMoneda { get; set; }
        public decimal Saldo_Ajustado { get; set; }
        public string Observaciones { get; set; }
        public string TipoNota { get; set; }
        public long ID_Compra { get; set; }
        public string CuentaContable { get; set; }
        public string DescripcionCuentaContable { get; set; }
    }
}
