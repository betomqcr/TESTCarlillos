namespace Modelo
{
    public class preciodiferenciado
    {
        public int Id { get; set; }
        public int IdAgente { get; set; }
        public int CodProveedor { get; set; }
        public string Proveedor { get; set; }
        public string Tipo { get; set; }
        public decimal Porcentaje { get; set; }
    }
}
