using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Ubicacion
    {
        public decimal IdProvincia { get; set; }
        public string Provincia { get; set; }
        public decimal IdCanton { get; set; }
        public string Canton { get; set; }
        public decimal IdDistrito { get; set; }
        public string Distrito { get; set; }
    }
}
