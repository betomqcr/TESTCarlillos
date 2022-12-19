using System;

namespace Modelo
{
    public class detalle_abonoccobrar
    {
        public long Consecutivo { get; set; }
        public long Id_Recibo { get; set; }
        public decimal Factura { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public decimal Saldo_Ant { get; set; }
        public decimal Intereses { get; set; }
        public decimal Abono { get; set; }
        public decimal Abono_SuMoneda { get; set; }
        public decimal Saldo { get; set; }
    }
}
