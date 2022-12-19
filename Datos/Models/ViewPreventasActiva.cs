using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewPreventasActiva
    {
        public double Ficha { get; set; }
        public long Id { get; set; }
        public DateTime Fecha { get; set; }
        public string BasedeDatos { get; set; }
        public string Tipo { get; set; }
        public long CodCliente { get; set; }
        public string NombreCliente { get; set; }
        public double Total { get; set; }
        public string Usuario { get; set; }
    }
}
