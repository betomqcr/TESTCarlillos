using System;
using System.Collections.Generic;

#nullable disable

namespace DatosFE.Models
{
    public partial class TiposIdentificacion
    {
        public TiposIdentificacion()
        {
            Emisors = new HashSet<Emisor>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int CodigoFe { get; set; }

        public virtual ICollection<Emisor> Emisors { get; set; }
    }
}
