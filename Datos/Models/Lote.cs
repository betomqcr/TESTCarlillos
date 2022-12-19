using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Lote
    {
        public long Id { get; set; }
        public string Numero { get; set; }
        public DateTime Vencimiento { get; set; }
        public double CantInicial { get; set; }
        public double CantActual { get; set; }
        public DateTime FechaEntrada { get; set; }
        public long CodArticulo { get; set; }
        public long Documento { get; set; }
        public string Tipo { get; set; }

        public virtual Inventario CodArticuloNavigation { get; set; }
    }
}
