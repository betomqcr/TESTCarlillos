using System;
using System.Collections.Generic;

#nullable disable

namespace DatosFE.Models
{
    public partial class Compra
    {
        public Compra()
        {
            ArticulosComprados = new HashSet<ArticulosComprado>();
        }

        public long IdCompra { get; set; }
        public double Factura { get; set; }
        public int CodigoProv { get; set; }
        public double SubTotalGravado { get; set; }
        public double SubTotalExento { get; set; }
        public double Descuento { get; set; }
        public double Impuesto { get; set; }
        public double TotalFactura { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Vence { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string MotivoGasto { get; set; }
        public bool Compra1 { get; set; }
        public bool Contabilizado { get; set; }
        public bool Consignacion { get; set; }
        public double Asiento { get; set; }
        public bool ContaInve { get; set; }
        public double AsientoInve { get; set; }
        public string TipoCompra { get; set; }
        public string CedulaUsuario { get; set; }
        public int CodMonedaCompra { get; set; }
        public bool FacturaCancelado { get; set; }
        public bool Gasto { get; set; }
        public double TipoCambio { get; set; }
        public double CambioImpuesto { get; set; }
        public bool Taller { get; set; }
        public bool Mascotas { get; set; }
        public double? NumOrden { get; set; }
        public bool Fec { get; set; }
        public string CodigoActividad { get; set; }
        public bool EnviadoDgt { get; set; }
        public string EstadoDgt { get; set; }
        public string ConsecutivoDgt { get; set; }
        public string ClaveDgt { get; set; }
        public bool Trans { get; set; }
        public string NumTrans { get; set; }
        public bool Prepagada { get; set; }
        public double PreAbono { get; set; }

        public virtual Proveedore CodigoProvNavigation { get; set; }
        public virtual ICollection<ArticulosComprado> ArticulosComprados { get; set; }
    }
}
