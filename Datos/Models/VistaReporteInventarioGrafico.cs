using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class VistaReporteInventarioGrafico
    {
        public DateTime Fecha { get; set; }
        public double Total { get; set; }
        public double NumFactura { get; set; }
        public string CodArticulo { get; set; }
        public string Descripcion { get; set; }
        public double Cantidad { get; set; }
        public long Codigo { get; set; }
        public long CodCliente { get; set; }
        public string NombreCliente { get; set; }
    }
}
