using System;

namespace Modelo
{
    public class ficha
    {
        public int Id { get; set; }
        public string Ficha { get; set; }
        public string Tipo { get; set; }
        public string BasedeDatos { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombre_Cliente { get; set; }
        public decimal Total { get; set; }
        public string Usuario { get; set; }
    }
}
