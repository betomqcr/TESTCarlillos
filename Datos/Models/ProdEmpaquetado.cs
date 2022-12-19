using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ProdEmpaquetado
    {
        public long IdVentaDetalle { get; set; }
        public long Codigo { get; set; }
        public string CodArticulo { get; set; }
        public string Descripcion { get; set; }
        public double Cantidad { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public string Cedula { get; set; }
    }
}
