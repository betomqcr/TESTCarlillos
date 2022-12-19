using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Ordencompra
    {
        public Ordencompra()
        {
            DetalleOrdencompras = new HashSet<DetalleOrdencompra>();
        }

        public long Orden { get; set; }
        public int Proveedor { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public bool Contado { get; set; }
        public bool Credito { get; set; }
        public double Diascredito { get; set; }
        public int Plazo { get; set; }
        public double Descuento { get; set; }
        public double Impuesto { get; set; }
        public double Total { get; set; }
        public string Observaciones { get; set; }
        public string Usuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Entregar { get; set; }
        public int CodMoneda { get; set; }
        public double SubTotalGravado { get; set; }
        public double SubTotalExento { get; set; }
        public double SubTotal { get; set; }
        public bool Anulado { get; set; }
        public int IdSucursal { get; set; }

        public virtual ICollection<DetalleOrdencompra> DetalleOrdencompras { get; set; }
    }
}
