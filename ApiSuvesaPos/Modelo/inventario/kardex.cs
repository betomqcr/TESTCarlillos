using System;

namespace Modelo
{
    public class kardex
    {
        public int Consecutivo { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Documento { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Exist_Ant { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Exist_Act { get; set; }
        public decimal Costo_Unit { get; set; }
        public decimal Costo_Mov { get; set; }
        public int Cod_Proveedor { get; set; }
        public int Cod_Cliente { get; set; }
        public int Cod_Moneda { get; set; }
        public decimal Tipo_Cambio { get; set; }
        public string Observaciones { get; set; }
        public decimal Exist_ActBod { get; set; }
        public decimal Exist_AntBod { get; set; }
        public int IdBodegaDestino { get; set; }
        public int IdBodegaOrigen { get; set; }
    }
}
