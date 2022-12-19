using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class GestionCobroBitacora
    {
        public decimal Id { get; set; }
        public string IdUsuario { get; set; }
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public decimal IdFactura { get; set; }
        public bool Contesto { get; set; }
        public string Mensaje { get; set; }
        public bool EnvioMensaje { get; set; }
        public bool EnvioCarta { get; set; }
        public decimal Etapa { get; set; }
        public string Pv { get; set; }
    }
}
