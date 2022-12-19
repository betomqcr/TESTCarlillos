using System;

namespace Datos.DTOs
{
    public class CartaExoneracionDTO
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public int IdTipoExoneracion { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaVence { get; set; }
        public double PorcentajeCompra { get; set; }
        public double Impuesto { get; set; }
        public string Nota { get; set; }
        public bool Estado { get; set; }
        public string IdUsuarioCreacion { get; set; }
        public string IdUsuarioModificacion { get; set; }
    }
}
