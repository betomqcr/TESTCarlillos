using System;
using System.Collections.Generic;

#nullable disable

namespace DatosFE.Models
{
    public partial class ObtenerDetallesDevolucion43
    {
        public long Devolucion { get; set; }
        public string Cabys { get; set; }
        public string Tipo { get; set; }
        public long Codigo { get; set; }
        public double Cantidad { get; set; }
        public string UnidadMedida { get; set; }
        public string Detalle { get; set; }
        public double PrecioUnitario { get; set; }
        public double MontoTotal { get; set; }
        public double Descuento { get; set; }
        public double MontoDescuento { get; set; }
        public string NaturalezaDescuento { get; set; }
        public double SubTotal { get; set; }
        public string CodigoImpuesto { get; set; }
        public string CodigoTarifa { get; set; }
        public double TarifaImpuesto { get; set; }
        public double MontoImpuesto { get; set; }
        public string TipoDocumentoExoneracion { get; set; }
        public string NumeroDocumentoExoneracion { get; set; }
        public string NombreInstitucionExoneracion { get; set; }
        public string FechaEmisionExoneracion { get; set; }
        public double MontoImpuestoExoneracion { get; set; }
        public double PorcentajeCompraExoneracion { get; set; }
        public double ImpuestoNeto { get; set; }
        public double MontoTotalLinea { get; set; }
    }
}
