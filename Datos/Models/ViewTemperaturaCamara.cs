using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewTemperaturaCamara
    {
        public decimal Id { get; set; }
        public DateTime? Fecha { get; set; }
        public string Horario { get; set; }
        public string IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Temperatura { get; set; }
    }
}
