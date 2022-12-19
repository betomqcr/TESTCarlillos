using System;

namespace Modelo
{
    public class abonoreintegro
    {
        public int IdAbono { get; set; }
        public int Id_Factura { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public bool Anulado { get; set; }
        public int Recibo { get; set; }
        public int NumApertura { get; set; }
    }
}
