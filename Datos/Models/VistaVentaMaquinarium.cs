using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class VistaVentaMaquinarium
    {
        public long Id { get; set; }
        public long IdFactura { get; set; }
        public double Total { get; set; }
        public DateTime Fecha { get; set; }
        public bool FacturaCancelado { get; set; }
        public long Codigo { get; set; }
        public string CodArticulo { get; set; }
        public string Descripcion { get; set; }
        public double Cantidad { get; set; }
        public double PrecioUnit { get; set; }
        public bool Anulado { get; set; }
        public double SubTotal { get; set; }
        public double NumFactura { get; set; }
        public bool? Maquinaria { get; set; }
    }
}
