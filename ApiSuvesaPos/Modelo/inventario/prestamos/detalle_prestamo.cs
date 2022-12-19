namespace Modelo
{
    public class detalle_prestamo
    {
        public int ID { get; set; }
        public int ID_prestamo { get; set; }
        public int codigo { get; set; }
        public string descripcion { get; set; }
        public decimal cantidad { get; set; }
        public decimal precio { get; set; }
        public bool entregado { get; set; }
        public decimal devuelto { get; set; }
    }
}
