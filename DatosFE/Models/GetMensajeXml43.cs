using System;
using System.Collections.Generic;

#nullable disable

namespace DatosFE.Models
{
    public partial class GetMensajeXml43
    {
        public decimal Id { get; set; }
        public string Estado { get; set; }
        public string Clave { get; set; }
        public string NumeroCedulaEmisor { get; set; }
        public string FechaEmisionDoc { get; set; }
        public int Mensaje { get; set; }
        public double MontoTotalImpuesto { get; set; }
        public double TotalFactura { get; set; }
        public string NumeroCedulaReceptor { get; set; }
        public string NumeroConsecutivoReceptor { get; set; }
        public string DetalleMensaje { get; set; }
        public string CodigoActividad { get; set; }
        public string CondicionImpuesto { get; set; }
        public double MontoTotalImpuestoAcreditar { get; set; }
        public double MontoTotalDeGastoAplicable { get; set; }
    }
}
