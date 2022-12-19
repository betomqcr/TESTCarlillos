using System;

namespace Modelo
{
    public class bitacora_reimpresiones
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string cedula { get; set; }
        public DateTime fecha { get; set; }
        public int factura { get; set; }
        public string Motivo { get; set; }
    }
}
