using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewReporteDevolucione
    {
        public double NumFactura { get; set; }
        public string Tipo { get; set; }
        public long CodCliente { get; set; }
        public string NombreCliente { get; set; }
        public DateTime FechaFactura { get; set; }
        public double MontoFactura { get; set; }
        public long Devolucion { get; set; }
        public double MontoDevolucion { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public long Codigo { get; set; }
        public string CodArticulo { get; set; }
        public string Descripcion { get; set; }
        public double Cantidad { get; set; }
        public double CantVet { get; set; }
        public double CantBod { get; set; }
    }
}
