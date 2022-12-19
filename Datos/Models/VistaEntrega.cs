using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class VistaEntrega
    {
        public string CodArticulo { get; set; }
        public string Descripcion { get; set; }
        public double Cantidad { get; set; }
        public double NumFactura { get; set; }
        public string NombreCliente { get; set; }
        public long IdFactura { get; set; }
        public bool Entregado { get; set; }
        public string Barras { get; set; }
        public string CedulaUsuario { get; set; }
        public string Nombre { get; set; }
        public long Codigo { get; set; }
        public string Barras2 { get; set; }
        public string Barras3 { get; set; }
        public decimal IdFactura1 { get; set; }
    }
}
