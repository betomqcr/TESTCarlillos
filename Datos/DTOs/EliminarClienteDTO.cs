using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DTOs
{
    public class EliminarClienteDTO
    {
        public string Cedula { get; set; }

        public string Nombre { get; set; }

        public string IdUsuarioModificacion { get; set; }
    }
}
