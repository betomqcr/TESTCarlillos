using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewSeriesDisponible
    {
        public long Codigo { get; set; }
        public string CodArticulo { get; set; }
        public string Descripcion { get; set; }
        public string Series { get; set; }
    }
}
