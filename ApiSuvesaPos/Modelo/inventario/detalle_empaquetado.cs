namespace Modelo
{
    public class detalle_empaquetado
    {
        // modelo usado por sistema de entregas
        public int id_venta_detalle { get; set; }
        public string Codarticulo { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public string minutos { get; set; }
        public bool Selección { get; set; }
        public string codmarca { get; set; }
        public int Id_Factura { get; set; }
        public int Num_Factura { get; set; }
        public decimal devoluciones { get; set; }
        public bool anulado { get; set; }
        public string nota_pantalla { get; set; }
    }
}
