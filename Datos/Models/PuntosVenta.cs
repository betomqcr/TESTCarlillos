using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class PuntosVenta
    {
        public decimal Id { get; set; }
        public DateTime Fecha { get; set; }
        public decimal NumFactura { get; set; }
        public string NombreCliente { get; set; }
        public string Usuario { get; set; }
        public string CodArticulo { get; set; }
        public double Costo { get; set; }
        public double PrecioVenta { get; set; }
        public double Plus1 { get; set; }
        public double Plus2 { get; set; }
    }
}
