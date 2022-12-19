using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewFacturasArchivada
    {
        public long Id { get; set; }
        public DateTime? Fecha { get; set; }
        public double NumFactura { get; set; }
        public string Tipo { get; set; }
        public string NombreCliente { get; set; }
        public double Total { get; set; }
        public string UsuarioCreo { get; set; }
        public bool Archivada { get; set; }
        public DateTime? FechaArchivo { get; set; }
        public string UsuarioArchivo { get; set; }
    }
}
