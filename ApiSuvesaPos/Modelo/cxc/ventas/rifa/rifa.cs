using System;

namespace Modelo
{
    public class rifa
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }
        public int cant_min { get; set; }
        public bool finalizada { get; set; }
        public bool anulada { get; set; }
    }
}
