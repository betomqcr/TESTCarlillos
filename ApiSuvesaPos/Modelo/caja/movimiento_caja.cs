using System;

namespace Modelo
{
    public class movimiento_caja
    {
        public int Id { get; set; }
        public bool Entrada { get; set; }
        public bool Salida { get; set; }
        public decimal Monto { get; set; }
        public int CodMoneda { get; set; }
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Observaciones { get; set; }
        public bool Anulado { get; set; }
        public int NumApertura { get; set; }
        public decimal TipoCambio { get; set; }
    }
}
