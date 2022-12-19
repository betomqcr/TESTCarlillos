using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewVentasUnida
    {
        public string Pv { get; set; }
        public long Id { get; set; }
        public double NumFactura { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Vence { get; set; }
        public long Identificacion { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Telefono01 { get; set; }
        public string CorreoComprobante { get; set; }
        public string CorreoRecibo { get; set; }
        public string EMail { get; set; }
        public double? Saldo { get; set; }
        public decimal Etapa { get; set; }
        public DateTime FechaEtapa { get; set; }
    }
}
