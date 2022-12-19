using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class PuntodeVentum
    {
        public decimal IdPuntoVenta { get; set; }
        public string PuntoVenta { get; set; }
        public string BasedeDatos { get; set; }
        public string Descripcion { get; set; }
        public decimal Relacion { get; set; }
        public int Mascota { get; set; }
        public int Taller { get; set; }
    }
}
