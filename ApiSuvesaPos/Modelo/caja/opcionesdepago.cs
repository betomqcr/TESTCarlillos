using System;

namespace Modelo
{
    public class opcionesdepago
    {
        public int id { get; set; }
        public decimal Documento { get; set; }
        public string TipoDocumento { get; set; }
        public decimal MontoPago { get; set; }
        public string FormaPago { get; set; }
        public decimal Denominacion { get; set; }
        public string Usuario { get; set; }
        public string Nombre { get; set; }
        public int CodMoneda { get; set; }
        public string Nombremoneda { get; set; }
        public decimal TipoCambio { get; set; }
        public DateTime Fecha { get; set; }
        public int Numapertura { get; set; }
        public decimal Vuelto { get; set; }
        public string NumeroDocumento { get; set; }
    }
}
