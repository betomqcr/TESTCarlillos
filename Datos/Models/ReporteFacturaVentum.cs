using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ReporteFacturaVentum
    {
        public long Id { get; set; }
        public double NumFactura { get; set; }
        public string Tipo { get; set; }
        public long CodCliente { get; set; }
        public string NombreCliente { get; set; }
        public string Orden { get; set; }
        public string CedulaUsuario { get; set; }
        public bool PagoComision { get; set; }
        public double SubTotal { get; set; }
        public double Descuento { get; set; }
        public double ImpVenta { get; set; }
        public double Total { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Vence { get; set; }
        public string CodEncargadoCompra { get; set; }
        public bool Contabilizado { get; set; }
        public long AsientoVenta { get; set; }
        public bool ContabilizadoCventa { get; set; }
        public long AsientoCosto { get; set; }
        public bool Anulado { get; set; }
        public int PagoImpuesto { get; set; }
        public bool FacturaCancelado { get; set; }
        public long NumApertura { get; set; }
        public bool Entregado { get; set; }
        public int CodMoneda { get; set; }
        public string MonedaNombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public double SubTotalGravada { get; set; }
        public double SubTotalExento { get; set; }
        public double Transporte { get; set; }
        public double TipoCambio { get; set; }
        public string Observaciones { get; set; }
        public bool Exonerar { get; set; }
        public bool Taller { get; set; }
        public bool Mascotas { get; set; }
        public long NumCaja { get; set; }
        public bool? Agente { get; set; }
        public long? CodAgente { get; set; }
        public long? Apartado { get; set; }
        public bool EnviadoMh { get; set; }
        public string Cedula { get; set; }
        public string ClaveMh { get; set; }
        public string EstadoMh { get; set; }
        public string TipoCedula { get; set; }
        public string ConsecutivoMh { get; set; }
        public bool ExcluirCxC { get; set; }
        public decimal IdAdelanto { get; set; }
        public bool Reenviar { get; set; }
        public decimal NumeroReenvio { get; set; }
        public string ClaveReenvio { get; set; }
        public string ConsecutivoReenvio { get; set; }
        public bool Archivada { get; set; }
        public string UsuarioArchivo { get; set; }
        public DateTime? FechaArchivo { get; set; }
        public bool Frecuente { get; set; }
        public decimal IdFacturaRemplaza { get; set; }
        public long IdVentaDetalle { get; set; }
        public long IdFactura { get; set; }
        public long Codigo { get; set; }
        public string CodArticulo { get; set; }
        public string Descripcion { get; set; }
        public double Cantidad { get; set; }
        public double PrecioCosto { get; set; }
        public double PrecioBase { get; set; }
        public double PrecioFlete { get; set; }
        public double PrecioOtros { get; set; }
        public double PrecioUnit { get; set; }
        public double DescuentoD { get; set; }
        public double MontoDescuento { get; set; }
        public double Impuesto { get; set; }
        public double MontoImpuesto { get; set; }
        public double SubtotalGravado { get; set; }
        public double SubTotalExcento { get; set; }
        public double SubTotalD { get; set; }
        public double Devoluciones { get; set; }
        public double NumeroEntrega { get; set; }
        public double MaxDescuento { get; set; }
        public int CodMonedaVenta { get; set; }
        public double TipoCambioValorCompra { get; set; }
        public string Lote { get; set; }
    }
}
