using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class VistaCodigoBarraDuplicado
    {
        public long Codigo { get; set; }
        public string Barras { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public double Existencia { get; set; }
    }
}
