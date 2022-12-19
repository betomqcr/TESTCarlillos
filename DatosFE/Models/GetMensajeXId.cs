using System;
using System.Collections.Generic;

#nullable disable

namespace DatosFE.Models
{
    public partial class GetMensajeXId
    {
        public decimal Id { get; set; }
        public string Clave { get; set; }
        public string NumeroCedulaEmisor { get; set; }
        public DateTime FechaEmisionDoc { get; set; }
        public string Mensaje { get; set; }
        public double MontoTotalImpuesto { get; set; }
        public double TotalFactura { get; set; }
        public string Estado { get; set; }
        public string Consecutivo { get; set; }
    }
}
