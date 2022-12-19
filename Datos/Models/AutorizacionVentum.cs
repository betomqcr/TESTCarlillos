using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class AutorizacionVentum
    {
        public decimal Id { get; set; }
        public decimal IdFactura { get; set; }
        public string IdCajero { get; set; }
        public string IdAdmin { get; set; }
        public string CedulaRetira { get; set; }
        public string NombreRetira { get; set; }
        public bool Cancelada { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public decimal IdApertura { get; set; }
        public decimal NumRecibo { get; set; }
        public string TelefonoRetira { get; set; }
        public bool Express { get; set; }
    }
}
