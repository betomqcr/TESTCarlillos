using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class VwReporteLote
    {
        public string CodArticulo { get; set; }
        public long CodInterno { get; set; }
        public string Numero { get; set; }
        public double CantInicial { get; set; }
        public DateTime Vencimiento { get; set; }
        public string Descripcion { get; set; }
    }
}
