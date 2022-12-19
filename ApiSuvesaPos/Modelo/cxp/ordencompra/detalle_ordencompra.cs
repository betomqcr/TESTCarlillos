namespace Modelo
{
    public class detalle_ordencompra
    {
        public int Id { get; set; }
        public int Orden { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal CostoUnitario { get; set; }
        public decimal Cantidad { get; set; }
        public decimal TotalCompra { get; set; }
        public decimal Porc_Descuento { get; set; }
        public decimal Descuento { get; set; }
        public decimal Porc_Impuesto { get; set; }
        public decimal impuesto { get; set; }
        public decimal OtrosCargos { get; set; }
        public decimal Monto_Flete { get; set; }
        public decimal Costo { get; set; }
        public decimal Gravado { get; set; }
        public decimal Exento { get; set; }
        public decimal Vendidos { get; set; }
        public decimal Exist_Actual { get; set; }
    }
}
