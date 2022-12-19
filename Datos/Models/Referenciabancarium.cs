using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Referenciabancarium
    {
        public long Cliente { get; set; }
        public string Sucursal { get; set; }
        public string Banco { get; set; }
        public string Cuenta { get; set; }
        public DateTime Fecha { get; set; }
        public long Id { get; set; }

        public virtual Cliente ClienteNavigation { get; set; }
    }
}
