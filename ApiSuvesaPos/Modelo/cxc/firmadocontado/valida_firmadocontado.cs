using System.Collections.Generic;

namespace Modelo
{
    public class valida_firmadocontado
    {
        public int ID_VALIDA_FIRMADOCONTADO { get; set; }
        public bool CONTADO { get; set; }
        public bool PVE { get; set; }
        public int MONTO_MAXIMO { get; set; }
        public bool EXIGE_NOMBRE { get; set; }
        public int MAXIMO_CLIENTE { get; set; }
        public int MAXIMO_AUTORIZA { get; set; }
        public int MAXIMO_RETIRA { get; set; }
        public List<Modelo.exepcion_firmadocontado> Exepcion_FirmadoContado { get; set; } = new List<Modelo.exepcion_firmadocontado>();
    }
}
