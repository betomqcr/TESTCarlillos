using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewFacturasRepetida
    {
        public string Tipo { get; set; }
        public double NumFactura { get; set; }
        public long CodCliente { get; set; }
        public int? Registro { get; set; }
    }
}
