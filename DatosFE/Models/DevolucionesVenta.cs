using System;
using System.Collections.Generic;

#nullable disable

namespace DatosFE.Models
{
    public partial class DevolucionesVenta
    {
        public DevolucionesVenta()
        {
            ArticulosVentasDevueltos = new HashSet<ArticulosVentasDevuelto>();
        }

        public long Devolucion { get; set; }
        public long IdFactura { get; set; }
        public double SaldoAntFact { get; set; }
        public double SubTotalGravado { get; set; }
        public double SubTotalExcento { get; set; }
        public double Descuento { get; set; }
        public double Impuesto { get; set; }
        public double Monto { get; set; }
        public DateTime Fecha { get; set; }
        public bool Contabilizado { get; set; }
        public long NumeroAsiento { get; set; }
        public bool Anulado { get; set; }
        public string CedulaUsuario { get; set; }
        public int CodMoneda { get; set; }
        public double Transporte { get; set; }
        public bool ContabilizadoCosto { get; set; }
        public long NumeroAsientoCosto { get; set; }
        public decimal Caja { get; set; }
        public long Consecutivo { get; set; }
        public bool Enviadodgt { get; set; }
        public string Estadodgt { get; set; }
        public string Consecutivodgt { get; set; }
        public string Clavedgt { get; set; }
        public double MontoDevolucion { get; set; }
        public decimal NumApertura { get; set; }
        public string UsuarioRecibio { get; set; }
        public string NotasDevolucion { get; set; }

        public virtual Venta IdFacturaNavigation { get; set; }
        public virtual ICollection<ArticulosVentasDevuelto> ArticulosVentasDevueltos { get; set; }
    }
}
