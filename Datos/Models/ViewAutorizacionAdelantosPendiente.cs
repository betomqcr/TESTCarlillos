using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewAutorizacionAdelantosPendiente
    {
        public decimal Id { get; set; }
        public decimal IdAdelanto { get; set; }
        public double NumFactura { get; set; }
        public string NombreCliente { get; set; }
        public DateTime? Fecha { get; set; }
        public string Cajero { get; set; }
        public string Administrador { get; set; }
        public string CedulaRetira { get; set; }
        public string NombreRetira { get; set; }
        public bool Facturado { get; set; }
    }
}
