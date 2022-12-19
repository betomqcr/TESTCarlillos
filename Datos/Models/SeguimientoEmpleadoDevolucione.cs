using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class SeguimientoEmpleadoDevolucione
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
        public int TransporteVentasDevueltas { get; set; }
        public string Agente { get; set; }
        public int DescuentoVentas { get; set; }
        public int SubtotalGravadoVentas { get; set; }
        public int ExcentoVentas { get; set; }
        public int ImpuestoVentas { get; set; }
        public double DescuentoDevolucion { get; set; }
        public double SubtotalGravadoDevolucion { get; set; }
        public double ExcentoDevolucion { get; set; }
        public double ImpuestoDevolucion { get; set; }
        public int TotalVenta { get; set; }
        public double TotalDevolucion { get; set; }
        public double? TipoCambio { get; set; }
    }
}
