using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class FichasxUsuario
    {
        public decimal Id { get; set; }
        public string IdUsuario { get; set; }
        public string Usuario { get; set; }
        public double Desde { get; set; }
        public double Hasta { get; set; }
        public decimal EnMostrador { get; set; }
        public int IdSucursal { get; set; }
    }
}
