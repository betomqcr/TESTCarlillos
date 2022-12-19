namespace Modelo
{
    public class articulos_ventas_devueltos
    {
        public long Consecutivo { get; set; }
        public long Devolucion { get; set; }
        public long Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal CantVet { get; set; }
        public decimal CantBod { get; set; }
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
        public int Id_Art_Venta { get; set; }
        public string id_articulo_V { get; set; }
        public bool devuelto { get; set; }
        public bool empaquetado { get; set; }
        public bool recibido { get; set; }
    }
}
