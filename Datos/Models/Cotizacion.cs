using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Cotizacion
    {
        public Cotizacion()
        {
            CotizacionDetalles = new HashSet<CotizacionDetalle>();
        }

        public long Cotizacion1 { get; set; }
        public DateTime Fecha { get; set; }
        public string CodCliente { get; set; }
        public string NombreCliente { get; set; }
        public string Contacto { get; set; }
        public int Validez { get; set; }
        public int TiempoEntrega { get; set; }
        public bool Contado { get; set; }
        public bool Credito { get; set; }
        public bool Anulado { get; set; }
        public int Dias { get; set; }
        public string Observaciones { get; set; }
        public double SubTotalGravada { get; set; }
        public double SubTotalExento { get; set; }
        public double Descuento { get; set; }
        public double PagoImpuesto { get; set; }
        public double Total { get; set; }
        public string Cedula { get; set; }
        public int CodMoneda { get; set; }
        public string MonedaNombre { get; set; }
        public double SubTotal { get; set; }
        public double TipoCambio { get; set; }
        public double ImpVenta { get; set; }
        public double Transporte { get; set; }
        public bool Venta { get; set; }
        public bool Exonerar { get; set; }
        public bool? Confirmada { get; set; }
        public string ConfirmadaPor { get; set; }
        public string EstadoActual { get; set; }
        public string ObservacionEstado { get; set; }
        public decimal IdFactura { get; set; }
        public string Telefono { get; set; }
        public string TipoCedula { get; set; }
        public string CedulaCliente { get; set; }
        public int? IdSucursal { get; set; }

        public virtual ICollection<CotizacionDetalle> CotizacionDetalles { get; set; }
    }
}
