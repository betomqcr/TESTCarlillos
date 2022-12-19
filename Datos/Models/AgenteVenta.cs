using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class AgenteVenta
    {
        public long Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public bool? Activo { get; set; }
        public bool? Anulado { get; set; }
        public decimal TipoPrecio { get; set; }
        public int IdSucursal { get; set; }
    }
}
