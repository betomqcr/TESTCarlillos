namespace Modelo
{
    public class articulos_compras_devueltos
    {
        public long Consecutivo { get; set; }
        public long Devolucion { get; set; }
        public long Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio_Costo { get; set; }
        public decimal Precio_Base { get; set; }
        public decimal Precio_Flete { get; set; }
        public decimal Precio_Otros { get; set; }
        public decimal Descuento { get; set; }
        public decimal Monto_Descuento { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Monto_Impuesto { get; set; }
        public decimal SubtotalGravado { get; set; }
        public decimal SubTotalExcento { get; set; }
        public decimal SubTotal { get; set; }
        public string Numero { get; set; }
    }
}
