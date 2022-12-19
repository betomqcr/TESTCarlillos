using System;

namespace Modelo
{
    public class abonoccobrar
    {
        public long Id_Recibo { get; set; }
        public long Num_Recibo { get; set; }
        public long Cod_Cliente { get; set; }
        public string Nombre_Cliente { get; set; }
        public decimal Saldo_Cuenta { get; set; }
        public decimal Monto { get; set; }
        public decimal Saldo_Actual { get; set; }
        public DateTime Fecha { get; set; }
        public string Observaciones { get; set; }
        public bool Anula { get; set; }
        public string Ced_Usuario { get; set; }
        public bool Contabilizado { get; set; }
        public long Asiento { get; set; }
        public int Cod_Moneda { get; set; }
        public string Cheque { get; set; }
        public int Num_Caja { get; set; }
        public string banco { get; set; }
        public int Num_Apertura { get; set; }
        public string EstadoEnvio { get; set; }
    }
}
