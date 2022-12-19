using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewSeriesVendida
    {
        public decimal Id { get; set; }
        public string Serie { get; set; }
        public DateTime Fecha { get; set; }
        public double NumFactura { get; set; }
        public string Tipo { get; set; }
        public string NombreCliente { get; set; }
        public string Vendedor { get; set; }
        public string CodArticulo { get; set; }
        public string Descripcion { get; set; }
    }
}
