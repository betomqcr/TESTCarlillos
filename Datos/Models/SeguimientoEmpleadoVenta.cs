using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class SeguimientoEmpleadoVenta
    {
        public double NumDoc { get; set; }
        public string TipoDoc { get; set; }
        public string TipoFac { get; set; }
        public DateTime? Fecha { get; set; }
        public string Empleado { get; set; }
        public int CodMoneda { get; set; }
        public long IdFac { get; set; }
        public string NombreCliente { get; set; }
        public int TransporteVentas { get; set; }
        public int TransporteVentasDevueltas { get; set; }
        public string Agente { get; set; }
        public double DescuentoVentas { get; set; }
        public double SubtotalGravadoVentas { get; set; }
        public double ExcentoVentas { get; set; }
        public double ImpuestoVentas { get; set; }
        public int DescuentoDevolucion { get; set; }
        public int SubtotalGravadoDevolucion { get; set; }
        public int ExcentoDevolucion { get; set; }
        public int ImpuestoDevolucion { get; set; }
        public double TotalVenta { get; set; }
        public int TotalDevolucion { get; set; }
        public double TipoCambio { get; set; }
    }
}
