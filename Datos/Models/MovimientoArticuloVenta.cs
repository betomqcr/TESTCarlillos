using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class MovimientoArticuloVenta
    {
        public double NumFactura { get; set; }
        public string Tipo { get; set; }
        public string NombreCliente { get; set; }
        public DateTime? Fecha { get; set; }
        public long Codigo { get; set; }
        public string CodArticulo { get; set; }
        public string Descripcion { get; set; }
        public double Cantidad { get; set; }
        public double PrecioUnit { get; set; }
        public long Id { get; set; }
    }
}
