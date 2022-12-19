using System;

namespace Modelo
{
    public class ventas_detalle
    {
        public long id_venta_detalle { get; set; }
        public long Id_Factura { get; set; }
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
        public decimal Devoluciones { get; set; }
        public decimal Numero_Entrega { get; set; }
        public decimal Max_Descuento { get; set; }
        public decimal Tipo_Cambio_ValorCompra { get; set; }
        public int Cod_MonedaVenta { get; set; }
        public string Lote { get; set; }
        public decimal CantVet { get; set; }
        public decimal CantBod { get; set; }
        public decimal Disminuye { get; set; }
        public bool empaquetado { get; set; }
        public string nota_pantalla { get; set; }
        public long id_bodega { get; set; }
        public decimal regalias { get; set; }
        public decimal CostoReal { get; set; }
        public int IdTipoExoneracion { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime FechaEmision { get; set; }
        public decimal PorcentajeCompra { get; set; }
        public int Id_Impuesto { get; set; }
        public bool entregado { get; set; }
        public int Entregados { get; set; }
        public int IdSerie { get; set; }
    }
}
