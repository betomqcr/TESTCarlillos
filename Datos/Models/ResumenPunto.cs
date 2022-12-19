using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ResumenPunto
    {
        public decimal Id { get; set; }
        public decimal IdFactura { get; set; }
        public DateTime Fecha { get; set; }
        public decimal NumFactura { get; set; }
        public string NombreCliente { get; set; }
        public string IdUsuario { get; set; }
        public string CodArticulo { get; set; }
        public string Descripcion { get; set; }
        public double Cantidad { get; set; }
        public double Costo { get; set; }
        public double Venta { get; set; }
        public double Descuento { get; set; }
        public double PlusCliente { get; set; }
        public double PlusRotacion { get; set; }
        public bool? IsVenta { get; set; }
        public bool IsCaja { get; set; }
        public bool IsDevolucion { get; set; }
        public bool IsAbono { get; set; }
        public bool IsEmpaque { get; set; }
        public double TiempoEmpaque { get; set; }
        public bool IsSolicitud { get; set; }
        public bool IsPedido { get; set; }
        public double TiempoPedido { get; set; }
        public bool IsRecibido { get; set; }
        public bool TiempoRecibido { get; set; }
        public bool IsVentaMascota { get; set; }
        public bool IsCierre { get; set; }
    }
}
