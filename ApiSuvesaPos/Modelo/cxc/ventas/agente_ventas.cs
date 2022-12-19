using System.Collections.Generic;

namespace Modelo
{
    public class agente_ventas
    {
        public int id { get; set; }
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string correo { get; set; }
        public bool activo { get; set; }
        public bool anulado { get; set; }
        public int TipoPrecio { get; set; }
        public List<Modelo.preciodiferenciado> PrecioDiferenciado { get; set; }
    }
}
