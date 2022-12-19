using System;
using System.Collections.Generic;

namespace Modelo
{
    public class aperturacaja
    {
        public int NApertura { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public string Observaciones { get; set; }
        public bool Anulado { get; set; }
        public string Cedula { get; set; }
        public long Num_Caja { get; set; }
        public Modelo.apertura_total_tope Apertura_Total_Tope { get; set; } = new Modelo.apertura_total_tope();
        public List<Modelo.apertura_denominaciones> apertura_denominaciones { get; set; } = new List<Modelo.apertura_denominaciones>();
    }

    public class apertura_total_tope
    {
        public int id_total_tope { get; set; }
        public int NApertura { get; set; }
        public int CodMoneda { get; set; }
        public decimal Monto_Tope { get; set; }
        public string MonedaNombre { get; set; }
    }

    public class apertura_denominaciones
    {
        public long Id { get; set; }
        public int Id_Apertura { get; set; }
        public int Id_Denominacion { get; set; }
        public decimal Monto { get; set; }
        public decimal Cantidad { get; set; }
    }
}
