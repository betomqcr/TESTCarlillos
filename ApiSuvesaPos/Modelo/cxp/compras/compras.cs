using System;
using System.Collections.Generic;

namespace Modelo
{
    public class compras
    {
        public long Id_Compra { get; set; }
        public decimal Factura { get; set; }
        public int CodigoProv { get; set; }
        public decimal SubTotalGravado { get; set; }
        public decimal SubTotalExento { get; set; }
        public decimal Descuento { get; set; }
        public decimal Impuesto { get; set; }
        public decimal TotalFactura { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Vence { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string MotivoGasto { get; set; }
        public bool Compra { get; set; }
        public bool Contabilizado { get; set; }
        public bool Consignacion { get; set; }
        public decimal Asiento { get; set; }
        public bool ContaInve { get; set; }
        public decimal AsientoInve { get; set; }
        public char TipoCompra { get; set; }
        public string CedulaUsuario { get; set; }
        public int Cod_MonedaCompra { get; set; }
        public bool FacturaCancelado { get; set; }
        public bool Gasto { get; set; }
        public decimal TipoCambio { get; set; }
        public decimal CambioImpuesto { get; set; }
        public bool Taller { get; set; }
        public bool Mascotas { get; set; }
        public decimal num_orden { get; set; }
        public bool FEC { get; set; }
        public string CodigoActividad { get; set; }
        public bool EnviadoDGT { get; set; }
        public string EstadoDGT { get; set; }
        public string ConsecutivoDGT { get; set; }
        public string ClaveDGT { get; set; }
        public bool Trans { get; set; }
        public string NumTrans { get; set; }
        public bool Prepagada { get; set; }
        public List<Modelo.articulos_comprados> Articulos_Comprados { get; set; } = new List<Modelo.articulos_comprados>();
        public List<Modelo.articulos_gastos> Articulos_Gastos { get; set; } = new List<Modelo.articulos_gastos>();
    }
}
