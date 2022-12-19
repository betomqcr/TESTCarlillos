using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class VentasFiscale
    {
        public long Id { get; set; }
        public DateTime Fecha { get; set; }
        public bool Anulado { get; set; }
        public double TipoCambio { get; set; }
        public double SubTotalGravada { get; set; }
        public double SubTotalExento { get; set; }
        public double ImpVenta { get; set; }
        public double Descuento { get; set; }
        public double Transporte { get; set; }
        public double Total { get; set; }
        public double? SubTotalGravadoDev { get; set; }
        public double? SubTotalExcentoDev { get; set; }
        public double? DescuentoDev { get; set; }
        public double? ImpuestoDev { get; set; }
        public double? TransporteDev { get; set; }
        public double? MontoDev { get; set; }
        public double? GravadoReal { get; set; }
        public double? ExcentoReal { get; set; }
        public double? DescuentoReal { get; set; }
        public double? ImpuestoReal { get; set; }
        public double? TransporteReal { get; set; }
        public double? MontoReal { get; set; }
        public double NumFactura { get; set; }
        public string Tipo { get; set; }
        public string NombreCliente { get; set; }
        public string Cedula { get; set; }
        public long NumCaja { get; set; }
    }
}
