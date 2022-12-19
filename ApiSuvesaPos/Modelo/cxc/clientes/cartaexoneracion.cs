using System;

namespace Modelo
{
    public class cartaexoneracion
    {
        public int Id { get; set; }
        public long Identificacion { get; set; }
        public int IdTipoExoneracion { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaVence { get; set; }
        public decimal PorcentajeCompra { get; set; }
        public decimal Impuesto { get; set; }
        public string Nota { get; set; }
    }
}
