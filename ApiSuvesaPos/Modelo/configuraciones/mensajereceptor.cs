using System;

namespace Modelo
{
    public class mensajereceptor
    {
        public int Id { get; set; }
        public string Clave { get; set; }
        public string NumeroCedulaEmisor { get; set; }
        public DateTime FechaEmisionDoc { get; set; }
        public string Mensaje { get; set; }
        public decimal MontoTotalImpuesto { get; set; }
        public decimal TotalFactura { get; set; }
        public string Estado { get; set; }
        public string Consecutivo { get; set; }
        public string Proveedor { get; set; }
        public string Moneda { get; set; }
        public DateTime FechaComprobante { get; set; }
        public string PDF { get; set; }
        public string DetalleMensaje { get; set; }
        public string CodigoActividad { get; set; }
        public string CondicionImpuesto { get; set; }
        public decimal MontoTotalImpuestoAcreditar { get; set; }
        public decimal MontoTotalDeGastoAplicable { get; set; }
    }
}
