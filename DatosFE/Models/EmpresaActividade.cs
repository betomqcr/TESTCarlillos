using System;
using System.Collections.Generic;

#nullable disable

namespace DatosFE.Models
{
    public partial class EmpresaActividade
    {
        public int Id { get; set; }
        public int IdEmisor { get; set; }
        public int IdActividad { get; set; }
        public bool EsPrincipal { get; set; }

        public virtual ActividadEmpresa IdActividadNavigation { get; set; }
        public virtual Emisor IdEmisorNavigation { get; set; }
    }
}
