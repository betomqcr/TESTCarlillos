using System;
using System.Collections.Generic;

#nullable disable

namespace DatosFE.Models
{
    public partial class ViewMensajeReceptor
    {
        public string Clave { get; set; }
        public string CedulaEmisor { get; set; }
        public string NombreEmisor { get; set; }
        public DateTime FechaEmision { get; set; }
        public string Mensaje { get; set; }
        public string Estado { get; set; }
        public double MontoTotalImpuesto { get; set; }
        public double TotalFactura { get; set; }
    }
}
