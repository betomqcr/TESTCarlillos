namespace Modelo
{
    public class apartado_detalle
    {
        public long Id_detalle { get; set; }
        public long Id_Apartado { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio_Costo { get; set; }
        public decimal Precio_Base { get; set; }
        public decimal Precio_Flete { get; set; }
        public decimal Precio_Otros { get; set; }
        public decimal Precio_Unit { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Monto_Impuesto { get; set; }
        public decimal SubtotalGravado { get; set; }
        public decimal SubTotalExcento { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Monto_descuento { get; set; }
        public decimal Descuento { get; set; }
        public decimal Max_Descuento { get; set; }
        public decimal Tipo_Cambio_ValorCompra { get; set; }
        public int Cod_MonedaVenta { get; set; }
        public long IdBodega { get; set; }
        public string cod_articulo { get; set; }
    }
}

