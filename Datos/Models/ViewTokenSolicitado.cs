using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewTokenSolicitado
    {
        public decimal Id { get; set; }
        public DateTime Fecha { get; set; }
        public string IdUsuarioSolicita { get; set; }
        public string UsuarioSolicita { get; set; }
        public decimal Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Token { get; set; }
    }
}
