using System;

namespace Modelo
{
    public class movimientosbodega
    {
        public long Boleta_Movimiento { get; set; }
        public int Bodega { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaEntrada { get; set; }
        public string Referencia { get; set; }
        public string Usuario { get; set; }
        public bool Anulado { get; set; }
        public string Cliente { get; set; }
    }
}
