namespace Modelo
{
    public class apartados
    {
        public long Id_Apartado { get; set; }
        public long Id_Cliente { get; set; }
        public string Nombrecliente { get; set; }
        public string Cedulausuario { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Imp_Venta { get; set; }
        public decimal Total { get; set; }
        //public DateTime Fecha { get; set; }
        //public DateTime Vence { get; set; }
        public bool Anulado { get; set; }
        public bool Cancelado { get; set; }
        public decimal SubTotalGravada { get; set; }
        public decimal SubTotalExento { get; set; }
        public string Observaciones { get; set; }
        public decimal Monto { get; set; }
        public decimal Descuento { get; set; }
        public decimal Tipo_Cambio { get; set; }
        public int Cod_Moneda { get; set; }
        //public List<Modelo.apartado_detalle> Apartado_Detalle { get; set; } = new List<Modelo.apartado_detalle>();
    }
}
