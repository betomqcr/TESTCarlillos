using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class TrasladoPuntoVentaDetalle
    {
        public decimal Id { get; set; }
        public decimal IdTrasladoPuntoVenta { get; set; }
        public decimal Codigo { get; set; }
        public string Descripcion { get; set; }
        public double Cantidad { get; set; }
    }
}
