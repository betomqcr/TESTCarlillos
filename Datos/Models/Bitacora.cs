using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Bitacora
    {
        public long Secuencia { get; set; }
        public string Tabla { get; set; }
        public string CampoClave { get; set; }
        public string DescripcionCampo { get; set; }
        public string Accion { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
        public double Costo { get; set; }
        public double VentaA { get; set; }
        public double VentaB { get; set; }
        public double VentaC { get; set; }
        public double VentaD { get; set; }
    }
}
