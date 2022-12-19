using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class VistaAnulado
    {
        public double NumFactura { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public string Administrador { get; set; }
    }
}
