using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class DevolucionesVenta1
    {
        public long Devolucion { get; set; }
        public DateTime Fecha { get; set; }
        public double SaldoAntFact { get; set; }
        public double SubTotalGravado { get; set; }
        public double SubTotalExcento { get; set; }
        public double Descuento { get; set; }
        public double Impuesto { get; set; }
        public double Monto { get; set; }
        public bool Anulado { get; set; }
        public double Transporte { get; set; }
        public double NumFactura { get; set; }
        public string Tipo { get; set; }
        public string NombreCliente { get; set; }
        public DateTime FechaVenta { get; set; }
        public double Total { get; set; }
        public string MonedaNombre { get; set; }
        public double TipoCambio { get; set; }
        public long Codigo { get; set; }
        public string Descripcion { get; set; }
        public double Cantidad { get; set; }
        public double PrecioUnit { get; set; }
        public double SubTotal { get; set; }
        public double MontoImpuesto { get; set; }
        public string Nombre { get; set; }
        public string Simbolo { get; set; }
        public decimal Caja { get; set; }
        public double MontoDevolucion { get; set; }
        public string UsuarioRecibio { get; set; }
    }
}
