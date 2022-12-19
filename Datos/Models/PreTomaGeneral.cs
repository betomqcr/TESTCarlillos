using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class PreTomaGeneral
    {
        public PreTomaGeneral()
        {
            PreTomaGeneralDetalles = new HashSet<PreTomaGeneralDetalle>();
        }

        public decimal IdPreToma { get; set; }
        public DateTime Fecha { get; set; }
        public bool Anulado { get; set; }
        public bool Aplicado { get; set; }
        public string Encargado { get; set; }

        public virtual ICollection<PreTomaGeneralDetalle> PreTomaGeneralDetalles { get; set; }
    }
}
