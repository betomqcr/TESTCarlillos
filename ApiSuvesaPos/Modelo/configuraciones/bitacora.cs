using System;

namespace Modelo
{
    public class bitacora
    {
        public long Secuencia { get; set; }
        public string Tabla { get; set; }
        public string Campo_Clave { get; set; }
        public string DescripcionCampo { get; set; }
        public string Accion { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
        public decimal Costo { get; set; }
        public decimal VentaA { get; set; }
        public decimal VentaB { get; set; }
        public decimal VentaC { get; set; }
        public decimal VentaD { get; set; }
    }
}
