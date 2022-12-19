using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class TomaGeneral
    {
        public TomaGeneral()
        {
            TomaGeneralDetalles = new HashSet<TomaGeneralDetalle>();
        }

        public decimal IdToma { get; set; }
        public DateTime Fecha { get; set; }
        public bool Anulado { get; set; }
        public bool Ajustado { get; set; }
        public decimal NumeroAjuste { get; set; }

        public virtual ICollection<TomaGeneralDetalle> TomaGeneralDetalles { get; set; }
    }
}
