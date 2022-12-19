using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewTrasladoPuntoVentum
    {
        public decimal Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string Observaciones { get; set; }
        public bool Anulado { get; set; }
        public string Usuario { get; set; }
    }
}
