using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class VistaProductosCotizadosXCliente
    {
        public long Cotizacion { get; set; }
        public DateTime Fecha { get; set; }
        public string CodArticulo { get; set; }
        public string Descripcion { get; set; }
        public string CodCliente { get; set; }
    }
}
