namespace Modelo
{
    public class tomageneraldetalle
    {
        public int IdTomaDetalle { get; set; }
        public int IdToma { get; set; }
        public int Codigo { get; set; }
        public string Cod_Articulo { get; set; }
        public string Barras { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public decimal Existencia { get; set; }
        public decimal Toma { get; set; }
        public decimal Diferencia { get; set; }
        public bool Contado { get; set; }
    }
}
