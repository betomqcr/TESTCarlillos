using System;

namespace Modelo
{
    public class bitacorainactivarcliente
    {
        public int Id { get; set; }
        public string Identificacion { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
        public bool Inactivo { get; set; }
        public string Motivo { get; set; }
    }
}
