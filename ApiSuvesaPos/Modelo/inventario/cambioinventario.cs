using System;

namespace Modelo
{
    public class cambioinventario
    {
        public int Id { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public int CodigoFacturado { get; set; }
        public decimal CantidadFacturado { get; set; }
        public int CodigoEntregado { get; set; }
        public decimal CantidadEntregado { get; set; }
        public decimal Diferencia { get; set; }
        public bool Aplicado { get; set; }
    }
}
