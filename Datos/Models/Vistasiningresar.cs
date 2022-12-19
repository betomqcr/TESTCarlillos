using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Vistasiningresar
    {
        public long IdArticuloComprados { get; set; }
        public double Cantidad { get; set; }
        public long Codigo { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int BodegaId { get; set; }
    }
}
