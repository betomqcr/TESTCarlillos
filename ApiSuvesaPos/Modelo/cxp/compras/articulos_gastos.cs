namespace Modelo
{
    public class articulos_gastos
    {
        public int Id_ArticuloComprados { get; set; }
        public int IdCompra { get; set; }
        public string Descripcion { get; set; }
        public decimal Base { get; set; }
        public decimal Monto_Flete { get; set; }
        public decimal OtrosCargos { get; set; }
        public decimal Costo { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Gravado { get; set; }
        public decimal Exento { get; set; }
        public decimal Descuento_P { get; set; }
        public decimal Descuento { get; set; }
        public decimal Impuesto_P { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Total { get; set; }
        public decimal Devoluciones { get; set; }
        public decimal NuevoCostoBase { get; set; }
        public string CuentaContable { get; set; }
        public int CodTipoCompra { get; set; }
        public string DescTipoCompra { get; set; }
    }
}
