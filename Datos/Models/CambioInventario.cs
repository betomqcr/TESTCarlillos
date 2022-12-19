using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class CambioInventario
    {
        public decimal Id { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public decimal CodigoFacturado { get; set; }
        public double CantidadFacturado { get; set; }
        public decimal CodigoEntregado { get; set; }
        public double CantidadEntregado { get; set; }
        public double Diferencia { get; set; }
        public bool Aplicado { get; set; }
    }
}
