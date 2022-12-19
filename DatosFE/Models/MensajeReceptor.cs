using System;
using System.Collections.Generic;

#nullable disable

namespace DatosFE.Models
{
    public partial class MensajeReceptor
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
        public string Proveedor { get; set; }
        public string Moneda { get; set; }
        public DateTime? FechaComprobante { get; set; }
        public string Pdf { get; set; }
        public string DetalleMensaje { get; set; }
        public string CodigoActividad { get; set; }
        public string CondicionImpuesto { get; set; }
        public double MontoTotalImpuestoAcreditar { get; set; }
        public int? CodProveedor { get; set; }
        public int? IdEmpresa { get; set; }
        public double MontoTotalDeGastoAplicable { get; set; }

        public virtual Proveedore CodProveedorNavigation { get; set; }
        public virtual Emisor IdEmpresaNavigation { get; set; }
    }
}
