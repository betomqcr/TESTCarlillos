using System;

namespace Modelo
{
    public class temperaturacamara
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Id_Usuario { get; set; }
        public string Temperatura { get; set; }
        public string Horario { get; set; }
    }
}
