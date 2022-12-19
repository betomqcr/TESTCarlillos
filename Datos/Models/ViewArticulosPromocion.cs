using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewArticulosPromocion
    {
        public long Codigo { get; set; }
        public string CodArticulo { get; set; }
        public string Descripcion { get; set; }
        public double Existencia { get; set; }
        public DateTime FechaLimite { get; set; }
        public double PrecioA { get; set; }
        public double PrecioPromo { get; set; }
    }
}
