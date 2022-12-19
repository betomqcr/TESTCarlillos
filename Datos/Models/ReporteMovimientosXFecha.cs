using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ReporteMovimientosXFecha
    {
        public string TipoMov { get; set; }
        public DateTime? FechaX { get; set; }
        public double TipoCambio { get; set; }
        public long Id { get; set; }
        public double GravadaVentas { get; set; }
        public double ExentoVentas { get; set; }
        public double ImpuestoVentas { get; set; }
        public double DescuentoVentas { get; set; }
        public double TransporteVentas { get; set; }
        public double TotalVentas { get; set; }
        public double GravadaDev { get; set; }
        public double ExcentoDev { get; set; }
        public double ImpuestoDev { get; set; }
        public double DescuentoDev { get; set; }
        public double TransporteDev { get; set; }
        public double TotalDev { get; set; }
        public double NumFactura { get; set; }
        public string Tipo { get; set; }
        public long Devolucion { get; set; }
        public decimal NumCaja { get; set; }
    }
}
