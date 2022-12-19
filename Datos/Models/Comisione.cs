using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Comisione
    {
        public DateTime? Fecha { get; set; }
        public long? Id { get; set; }
        public double? NumFactura { get; set; }
        public string Descripcion { get; set; }
        public double PrecioUnit { get; set; }
        public double Cantidad { get; set; }
        public double Devoluciones { get; set; }
        public double DevReg { get; set; }
        public double Cantidadreal { get; set; }
        public double? SubTotalReal { get; set; }
        public double Comision { get; set; }
        public double TotalComision { get; set; }
        public string Empleado { get; set; }
        public string Agente { get; set; }
        public int? CodMoneda { get; set; }
        public string Tipo { get; set; }
    }
}
