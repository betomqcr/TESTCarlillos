using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Rifa
    {
        public long Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int CantMin { get; set; }
        public bool Finalizada { get; set; }
        public bool Anulada { get; set; }
        public int IdSucursal { get; set; }
    }
}
