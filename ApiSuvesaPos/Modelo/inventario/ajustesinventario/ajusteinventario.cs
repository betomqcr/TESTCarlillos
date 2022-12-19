namespace Modelo
{
    public class ajusteinventario
    {
        public long Consecutivo { get; set; }
        //public DateTime Fecha { get; set; }
        public bool Anula { get; set; }
        public string Cedula { get; set; }
        public decimal TotalEntrada { get; set; }
        public decimal TotalSalida { get; set; }
        public decimal SaldoAjuste { get; set; }
        public decimal Asiento { get; set; }
        public bool Contabilizado { get; set; }
        //public List<ajusteinventario_detalle> AjusteInventario_Detalle { get; set; } = new List<ajusteinventario_detalle>();
    }
}
