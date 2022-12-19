using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Marca
    {
        public string Marca1 { get; set; }

        public int CodMarca { get; set; }

        public bool Estado { get; set; }

        public string IdUsuarioCreacion { get; set; }

        public DateTime FechaCreacion { get; set; }

        public string IdUsuarioModificacion { get; set; }

        public Nullable<DateTime> FechaModificacion { get; set; }



    }
}
