using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class SeguimientoEmpleadoTransporteDevolucione
    {
        public long NumDoc { get; set; }
        public string TipoDoc { get; set; }
        public string TipoFac { get; set; }
        public DateTime? Fecha { get; set; }
        public string Empleado { get; set; }
        public int? CodMoneda { get; set; }
        public long IdFac { get; set; }
        public string NombreCliente { get; set; }
        public int TransporteVentas { get; set; }
        public double? TransporteVentasDevueltas { get; set; }
        public string Agente { get; set; }
        public int DescuentoVentas { get; set; }
        public int SubtotalGravadoVentas { get; set; }
        public int ExcentoVentas { get; set; }
        public int ImpuestoVentas { get; set; }
        public int DescuentoDevolucion { get; set; }
        public int SubtotalGravadoDevolucion { get; set; }
        public int ExcentoDevolucion { get; set; }
        public int ImpuestoDevolucion { get; set; }
        public int TotalVenta { get; set; }
        public int TotalDevolucion { get; set; }
        public double? TipoCambio { get; set; }
    }
}
