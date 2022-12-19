using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class RegistroPermisohabilitar
    {
        public string CedulaUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public decimal? Codigo { get; set; }
        public string Administrador { get; set; }
    }
}
