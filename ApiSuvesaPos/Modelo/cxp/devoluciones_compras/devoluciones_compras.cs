using System;

namespace Modelo
{
    public class devoluciones_compras
    {
        public long Devolucion { get; set; }
        public long Id_Factura_Compra { get; set; }
        public decimal SaldoAnt_Fact { get; set; }
        public decimal SubTotalGravado { get; set; }
        public decimal SubTotalExcento { get; set; }
        public decimal Descuento { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public bool Contabilizado { get; set; }
        public decimal Asiento { get; set; }
        public bool Anulado { get; set; }
        public string Cedula_Usuario { get; set; }
        public int Cod_Moneda { get; set; }
        public string NombrePro { get; set; }
        public bool ContaInventario { get; set; }
        public decimal AsientoInventario { get; set; }
        public DateTime FechaEntrada { get; set; }
    }
}
