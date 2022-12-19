using System;

namespace Modelo
{
    public class descuentos
    {
        public int IdDescuento { get; set; }
        public int IdProveedor { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public decimal Descuento { get; set; }
        public bool Confirmado { get; set; }
        public string ContactoConfirmo { get; set; }
    }
}
