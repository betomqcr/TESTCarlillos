using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Ganancia
    {
        public DateTime Fecha { get; set; }
        public long Id { get; set; }
        public double NumFactura { get; set; }
        public string Descripcion { get; set; }
        public double PrecioUnit { get; set; }
        public double PrecioCosto { get; set; }
        public double Cantidad { get; set; }
        public double Devoluciones { get; set; }
        public double Cantidadreal { get; set; }
        public double SubTotalReal { get; set; }
        public int CodMoneda { get; set; }
        public double Ganancia1 { get; set; }
        public string Cliente { get; set; }
    }
}
