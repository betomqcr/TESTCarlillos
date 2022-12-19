using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class BitacoraInactivarCliente
    {
        public decimal Id { get; set; }
        public string Identificacion { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
        public bool Inactivo { get; set; }
        public string Motivo { get; set; }
    }
}
