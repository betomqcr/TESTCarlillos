using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class RegistroPermisoAjuste
    {
        public string CedulaUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public decimal? IdMovimiento { get; set; }
        public string Administrador { get; set; }
    }
}
