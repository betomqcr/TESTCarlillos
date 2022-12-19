using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ExepcionFirmadocontado
    {
        public decimal IdExepcionFirmadocontado { get; set; }
        public decimal IdValidaFirmadocontado { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }

        public virtual ValidaFirmadocontado IdValidaFirmadocontadoNavigation { get; set; }
    }
}
