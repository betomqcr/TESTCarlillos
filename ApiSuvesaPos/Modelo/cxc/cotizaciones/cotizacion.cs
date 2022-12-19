using System;

namespace Modelo
{
    public class cotizacion
    {
        public long Cotizacion { get; set; }
        public DateTime Fecha { get; set; }
        public string Cod_Cliente { get; set; }
        public string Nombre_Cliente { get; set; }
        public string Contacto { get; set; }
        public int Validez { get; set; }
        public int TiempoEntrega { get; set; }
        public bool Contado { get; set; }
        public bool Credito { get; set; }
        public bool Anulado { get; set; }
        public int Dias { get; set; }
        public string Observaciones { get; set; }
        public decimal SubTotalGravada { get; set; }
        public decimal SubTotalExento { get; set; }
        public decimal Descuento { get; set; }
        public decimal PagoImpuesto { get; set; }
        public decimal Total { get; set; }
        public string Cedula { get; set; }
        public int CodMoneda { get; set; }
        public string MonedaNombre { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Tipo_Cambio { get; set; }
        public decimal Imp_Venta { get; set; }
        public decimal Transporte { get; set; }
        public bool Venta { get; set; }
        public bool Exonerar { get; set; }
        public bool confirmada { get; set; }
        public string confirmada_por { get; set; }
        public string EstadoActual { get; set; }
        public string ObservacionEstado { get; set; }
        public int Id_Factura { get; set; }
        public string Telefono { get; set; }
        public string TipoCedula { get; set; }
        public string CedulaCliente { get; set; }
        public Modelo.cotizacion_detalle Cotizacion_Detalle { get; set; } = new Modelo.cotizacion_detalle();
    }
}
