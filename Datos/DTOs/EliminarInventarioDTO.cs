using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DTOs
{
    public class EliminarInventarioDTO
    {
        public string Cod_Articulo { get; set; }

        public string Descripcion { get; set; }

        public string IdUsuarioModificacion { get; set; }
    }
}
