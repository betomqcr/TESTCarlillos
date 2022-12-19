using System;

namespace Modelo
{
    public class devoluciones_ventas
    {
        public long Devolucion { get; set; }
        public long Id_Factura { get; set; }
        public decimal SaldoAnt_Fact { get; set; }
        public decimal SubTotalGravado { get; set; }
        public decimal SubTotalExcento { get; set; }
        public decimal Descuento { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public bool Contabilizado { get; set; }
        public long NumeroAsiento { get; set; }
        public bool Anulado { get; set; }
        public string Cedula_Usuario { get; set; }
        public int Cod_Moneda { get; set; }
        public decimal Transporte { get; set; }
        public bool ContabilizadoCosto { get; set; }
        public long NumeroAsientoCosto { get; set; }
        public int caja { get; set; }
        public long CONSECUTIVO { get; set; }
        public bool ENVIADODGT { get; set; }
        public string ESTADODGT { get; set; }
        public string CONSECUTIVODGT { get; set; }
        public string CLAVEDGT { get; set; }
        public decimal MontoDevolucion { get; set; }
        public int Num_Apertura { get; set; }
        public string UsuarioRecibio { get; set; }
        public string NotasDevolucion { get; set; }
        public Modelo.articulos_ventas_devueltos Articulos_Ventas_Devueltos { get; set; } = new Modelo.articulos_ventas_devueltos();
    }
}
