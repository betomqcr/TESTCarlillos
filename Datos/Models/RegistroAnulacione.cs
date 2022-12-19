using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class RegistroAnulacione
    {
        public string CedulaUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public decimal? IdFactura { get; set; }
        public bool Justificacion { get; set; }
        public bool Permiso { get; set; }
        public string Administrador { get; set; }
    }
}
