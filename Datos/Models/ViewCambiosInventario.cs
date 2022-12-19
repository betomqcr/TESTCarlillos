using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewCambiosInventario
    {
        public decimal Id { get; set; }
        public bool Aplicado { get; set; }
        public string IdUsuario { get; set; }
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public long CodigoF { get; set; }
        public string CodArticulof { get; set; }
        public string Descripcionf { get; set; }
        public double CantidadFacturado { get; set; }
        public long CodigoE { get; set; }
        public string CodArticuloE { get; set; }
        public string DescripcionE { get; set; }
        public double CantidadEntregado { get; set; }
        public double Diferencia { get; set; }
    }
}
