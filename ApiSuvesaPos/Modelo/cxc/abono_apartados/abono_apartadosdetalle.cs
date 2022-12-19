namespace Modelo
{
    public class abono_apartadosdetalle
    {
        public int id_detalleabono { get; set; }
        public int apartado { get; set; }
        public int Id_abonoapartado { get; set; }
        public decimal Monto { get; set; }
        public decimal Saldo_Ant { get; set; }
        public decimal Intereses { get; set; }
        public decimal Abono { get; set; }
        public decimal Abono_SuMoneda { get; set; }
        public decimal Saldo { get; set; }
    }
}
