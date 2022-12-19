using System;

namespace Modelo
{
    public class controllotes
    {
        public int Id { get; set; }
        public int IdReferencia { get; set; }
        public string Lote { get; set; }
        public DateTime Vence { get; set; }
        public int Codigo { get; set; }
        public string Barras { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Actual { get; set; }
        public bool ImpresoGeneral { get; set; }
    }
}
