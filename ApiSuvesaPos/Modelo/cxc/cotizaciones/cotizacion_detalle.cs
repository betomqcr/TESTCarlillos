namespace Modelo
{
    public class cotizacion_detalle
    {
        public long Numero { get; set; }
        public long Cotizacion { get; set; }
        public long Codigo { get; set; }
        public string CodArticulo { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio_Costo { get; set; }
        public decimal Precio_Base { get; set; }
        public decimal Precio_Flete { get; set; }
        public decimal Precio_Otros { get; set; }
        public decimal Precio_Unit { get; set; }
        public decimal Descuento { get; set; }
        public decimal Monto_Descuento { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Monto_Impuesto { get; set; }
        public decimal SubtotalGravado { get; set; }
        public decimal SubTotalExcento { get; set; }
        public decimal SubTotal { get; set; }
        public string SubFamilia { get; set; }
        public decimal Max_Descuento { get; set; }
        public decimal Tipo_Cambio_ValorCompra { get; set; }
        public int Cod_MonedaVenta { get; set; }
    }
}
