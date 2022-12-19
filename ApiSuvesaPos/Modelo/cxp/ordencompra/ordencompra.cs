using System;

namespace Modelo
{
    public class ordencompra
    {
        public int Orden { get; set; }
        public int Proveedor { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public bool contado { get; set; }
        public bool credito { get; set; }
        public decimal diascredito { get; set; }
        public int Plazo { get; set; }
        public decimal Descuento { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Total { get; set; }
        public string Observaciones { get; set; }
        public string Usuario { get; set; }
        public string NombreUsuario { get; set; }
        public string entregar { get; set; }
        public int Cod_Moneda { get; set; }
        public decimal SubTotalGravado { get; set; }
        public decimal SubTotalExento { get; set; }
        public decimal SubTotal { get; set; }
        public bool Anulado { get; set; }
    }
}

