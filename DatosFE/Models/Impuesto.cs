using System;
using System.Collections.Generic;

#nullable disable

namespace DatosFE.Models
{
    public partial class Impuesto
    {
        public Impuesto()
        {
            Inventarios = new HashSet<Inventario>();
        }

        public int IdImpuesto { get; set; }
        public string Impuesto1 { get; set; }
        public string CodigoImpuesto { get; set; }
        public string CodigoTarifa { get; set; }
        public double Porcentaje { get; set; }
        public string Simbolo { get; set; }
        public bool Inactivo { get; set; }

        public virtual ICollection<Inventario> Inventarios { get; set; }
    }
}
