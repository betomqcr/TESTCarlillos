using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewVentasHuber
    {
        public DateTime Fecha { get; set; }
        public double NumFactura { get; set; }
        public string NombreCliente { get; set; }
        public string CodArticulo { get; set; }
        public string Descripcion { get; set; }
        public double Cantidad { get; set; }
    }
}
