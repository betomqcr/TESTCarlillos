namespace Modelo
{
    public class detalle_abonocpagar
    {
        public int Id_Detalle_abonocpagar { get; set; }
        public decimal Factura { get; set; }
        public int Cod_Proveedor { get; set; }
        public decimal MontoFactura { get; set; }
        public decimal Saldo_Ant { get; set; }
        public decimal Abono { get; set; }
        public decimal Abono_SuMoneda { get; set; }
        public decimal Saldo_Actual { get; set; }
        public long Id_Abonocpagar { get; set; }
        public decimal Id_Compra { get; set; }
    }
}

