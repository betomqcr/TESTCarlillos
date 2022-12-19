using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewListaMag
    {
        public long Codigo { get; set; }
        public string CodArticulo { get; set; }
        public string Descripcion { get; set; }
        public double Iventa { get; set; }
    }
}
