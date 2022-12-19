using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class DetallePrestamo
    {
        public long Id { get; set; }
        public long IdPrestamo { get; set; }
        public long Codigo { get; set; }
        public string Descripcion { get; set; }
        public double Cantidad { get; set; }
        public double Precio { get; set; }
        public bool Entregado { get; set; }
        public double Devuelto { get; set; }

        public virtual Prestamo IdPrestamoNavigation { get; set; }
    }
}
