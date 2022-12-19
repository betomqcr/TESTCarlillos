namespace Modelo
{
    public class prestamo
    {
        public int ID { get; set; }
        //public DateTime fecha { get; set; }
        public bool estado { get; set; }
        public bool anulado { get; set; }
        public bool Entrada { get; set; }
        public bool Salida { get; set; }
        public string observacion { get; set; }
        public string nombre_destino { get; set; }
        public string boleta { get; set; }
        public int destinatario { get; set; }
        public string nombre_destinatario { get; set; }
        public int destino { get; set; }
        public string transportista { get; set; }
        public string Id_UsuariCreo { get; set; }
        public string BoletaProveedor { get; set; }
        //public List<detalle_prestamo> Detalle_Prestamo { get; set; } = new List<detalle_prestamo>();
    }
}
