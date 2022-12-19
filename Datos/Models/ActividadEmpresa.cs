using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ActividadEmpresa
    {
        public ActividadEmpresa()
        {
            EmpresaActividades = new HashSet<EmpresaActividade>();
        }

        public int IdActividad { get; set; }
        public string Actividad { get; set; }

        public virtual ICollection<EmpresaActividade> EmpresaActividades { get; set; }
    }
}
