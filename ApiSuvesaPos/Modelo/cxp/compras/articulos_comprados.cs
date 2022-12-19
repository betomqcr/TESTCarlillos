namespace Modelo
{
    public class articulos_comprados
    {
        public long Id_ArticuloComprados { get; set; }
        public long IdCompra { get; set; }
        public long Codigo { get; set; }
        public string CodArticulo { get; set; }
        public string Descripcion { get; set; }
        public decimal Base { get; set; }
        public decimal Monto_Flete { get; set; }
        public decimal OtrosCargos { get; set; }
        public decimal Costo { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Regalias { get; set; }
        public decimal Gravado { get; set; }
        public decimal Exento { get; set; }
        public decimal Descuento_P { get; set; }
        public decimal Descuento { get; set; }
        public decimal Impuesto_P { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Total { get; set; }
        public decimal Devoluciones { get; set; }
        public decimal Precio_A { get; set; }
        public decimal Precio_B { get; set; }
        public decimal Precio_C { get; set; }
        public decimal Precio_D { get; set; }
        public int CodMonedaVenta { get; set; }
        public decimal NuevoCostoBase { get; set; }
        public string Lote { get; set; }
        public bool Bonificado { get; set; }
        public long CodigoBonificado { get; set; }
        public decimal CantidadBonificado { get; set; }
        public decimal CostoBonificado { get; set; }
        public decimal SubTotalBonificado { get; set; }
        public string CodArticuloBonificacion { get; set; }
        public string CodCabys { get; set; }
    }
}
