using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ValidaFirmadocontado
    {
        public ValidaFirmadocontado()
        {
            ExepcionFirmadocontados = new HashSet<ExepcionFirmadocontado>();
        }

        public decimal IdValidaFirmadocontado { get; set; }
        public bool Contado { get; set; }
        public bool Pve { get; set; }
        public decimal MontoMaximo { get; set; }
        public bool ExigeNombre { get; set; }
        public decimal MaximoCliente { get; set; }
        public decimal MaximoAutoriza { get; set; }
        public decimal MaximoRetira { get; set; }

        public virtual ICollection<ExepcionFirmadocontado> ExepcionFirmadocontados { get; set; }
    }
}
