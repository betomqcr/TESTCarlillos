using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewAutorizacionFacturasPendiente
    {
        public string BasedeDatos { get; set; }
        public string PuntoVenta { get; set; }
        public decimal Id { get; set; }
        public decimal IdFactura { get; set; }
        public long NumApertura { get; set; }
        public double NumFactura { get; set; }
        public string NombreCliente { get; set; }
        public DateTime? Fecha { get; set; }
        public string Cajero { get; set; }
        public string IdAdmin { get; set; }
        public string Administrador { get; set; }
        public string CedulaRetira { get; set; }
        public string NombreRetira { get; set; }
        public string TelefonoRetira { get; set; }
        public bool Cancelada { get; set; }
        public double? Total { get; set; }
        public bool Express { get; set; }
    }
}
