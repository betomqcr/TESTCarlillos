using System;

namespace Modelo
{
    public class abono_apartados
    {
        public int Id_abonoapartado { get; set; }
        public int Cod_Cliente { get; set; }
        public string Nombre_Cliente { get; set; }
        public decimal Saldo_Cuenta { get; set; }
        public decimal Monto { get; set; }
        public decimal Saldo_Actual { get; set; }
        public DateTime Fecha { get; set; }
        public string Observaciones { get; set; }
        public bool Anula { get; set; }
        public string Ced_Usuario { get; set; }
        public int Cod_Moneda { get; set; }
        public int Num_Recibo { get; set; }
    }
}
