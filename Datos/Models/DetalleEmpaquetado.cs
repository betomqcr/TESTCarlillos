using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class DetalleEmpaquetado
    {
        public long IdVentaDetalle { get; set; }
        public string Descripcion { get; set; }
        public double Cantidad { get; set; }
        public double Devoluciones { get; set; }
        public bool? Empaquetado { get; set; }
        public DateTime Fecha { get; set; }
        public string CodArticulo { get; set; }
        public int CodMarca { get; set; }
        public bool? Pantalla { get; set; }
        public long IdFactura { get; set; }
        public double NumFactura { get; set; }
        public bool Anulado { get; set; }
        public string NotaPantalla { get; set; }
    }
}
