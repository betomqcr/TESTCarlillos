using System;

namespace Modelo
{
    public class devolucion_prestamo
    {
        public int id { get; set; }
        public int id_detalle_prestamo { get; set; }
        public int id_prestamo { get; set; }
        public int codigo { get; set; }
        public string descripcion { get; set; }
        public decimal cantidad { get; set; }
        public DateTime fecha { get; set; }
        public bool anulado { get; set; }
    }
}
