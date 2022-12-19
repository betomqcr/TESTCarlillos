using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ComisionesVentasTransporte
    {
        public double NumDoc { get; set; }
        public string TipoDoc { get; set; }
        public string TipoFac { get; set; }
        public DateTime? Fecha { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Empleado { get; set; }
        public string Agente { get; set; }
        public int CodMoneda { get; set; }
        public int SubTotalVentaBruta { get; set; }
        public int MaxComision { get; set; }
        public int ComisionVentaBruta { get; set; }
        public int SubTotalDevoluciones { get; set; }
        public int ComisionDevoluciones { get; set; }
        public long IdFac { get; set; }
        public string NombreCliente { get; set; }
        public int IdDetFac { get; set; }
        public double TransporteVentas { get; set; }
        public int TransporteVentasDevueltas { get; set; }
    }
}
