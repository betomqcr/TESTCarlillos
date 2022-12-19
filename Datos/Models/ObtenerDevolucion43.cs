using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ObtenerDevolucion43
    {
        public long Devolucion { get; set; }
        public string CodigoActividad { get; set; }
        public string BasedeDatos { get; set; }
        public string TipoFactura { get; set; }
        public DateTime Fecha { get; set; }
        public long Expr2 { get; set; }
        public string Clave { get; set; }
        public string Consecutivo { get; set; }
        public string FechaEmision { get; set; }
        public DateTime Expr1 { get; set; }
        public string NombreEmisor { get; set; }
        public string TipoEmisor { get; set; }
        public string NumeroEmisor { get; set; }
        public decimal ProvinciaEmisor { get; set; }
        public string CantonEmisor { get; set; }
        public string DistritoEmisor { get; set; }
        public string OtrasSenasEmisor { get; set; }
        public string CodigoPaisEmisor { get; set; }
        public string NumTelefonoEmisor { get; set; }
        public string CorreoElectronicoEmisor { get; set; }
        public string NombreReceptor { get; set; }
        public string NumeroReceptor { get; set; }
        public string NumTelefonoReceptor { get; set; }
        public string CorreoElectronicoReceptor { get; set; }
        public string TipoReceptor { get; set; }
        public string CondicionVenta { get; set; }
        public string MedioPago { get; set; }
        public string CodigoMoneda { get; set; }
        public double TipoCambio { get; set; }
        public double? TotalServGravados { get; set; }
        public double? TotalServExentos { get; set; }
        public double? TotalServExonerado { get; set; }
        public double? TotalMercanciasGravadas { get; set; }
        public double? TotalMercanciasExentas { get; set; }
        public double? TotalMercExonerada { get; set; }
        public double? TotalGravado { get; set; }
        public double? TotalExento { get; set; }
        public double? TotalExonerado { get; set; }
        public double? TotalVenta { get; set; }
        public double? TotalDescuentos { get; set; }
        public double? TotalVentaNeta { get; set; }
        public double? TotalImpuesto { get; set; }
        public double? TotalComprobante { get; set; }
        public string TipoDocReferencia { get; set; }
        public string NumeroReferencia { get; set; }
        public string FechaEmisionReferencia { get; set; }
        public string CodigoReferencia { get; set; }
        public string RazonReferencia { get; set; }
        public string NumeroResolucion { get; set; }
        public string FechaResolucion { get; set; }
    }
}
