using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Aperturacaja
    {
        public Aperturacaja()
        {
            AperturaDenominaciones = new HashSet<AperturaDenominacione>();
            AperturaTotalTopes = new HashSet<AperturaTotalTope>();
        }

        public int Napertura { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public string Observaciones { get; set; }
        public bool Anulado { get; set; }
        public string Cedula { get; set; }
        public long NumCaja { get; set; }
        public int IdSucursal { get; set; }

        public virtual ICollection<AperturaDenominacione> AperturaDenominaciones { get; set; }
        public virtual ICollection<AperturaTotalTope> AperturaTotalTopes { get; set; }
    }
}
