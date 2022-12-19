using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ComisionesVentasDevueltas1
    {
        public long? NumDoc { get; set; }
        public string TipoDoc { get; set; }
        public string TipoFac { get; set; }
        public DateTime? Fecha { get; set; }
        public long? Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Empleado { get; set; }
        public int? CodMoneda { get; set; }
        public int SubTotalVentaBruta { get; set; }
        public double? MaxComision { get; set; }
        public int ComisionVentaBruta { get; set; }
        public double? SubTotalDevoluciones { get; set; }
        public double? ComisionDevolucion { get; set; }
        public long? IdFac { get; set; }
        public string NombreCliente { get; set; }
        public int IdDetFac { get; set; }
        public int TransporteVentas { get; set; }
        public int TransporteVentasDevueltas { get; set; }
        public int MontoImpuesto { get; set; }
        public double? DevolucionesImpuesto { get; set; }
        public string Agente { get; set; }
        public long? Id { get; set; }
        public decimal? NumCaja { get; set; }
    }
}
