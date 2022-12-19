namespace Modelo
{
    public class impuestos
    {
        public int Id_Impuesto { get; set; }
        public string Impuesto { get; set; }
        public string Codigo_Impuesto { get; set; }
        public string Codigo_Tarifa { get; set; }
        public decimal Porcentaje { get; set; }
        public string Simbolo { get; set; }
        public bool Inactivo { get; set; }
    }
}
