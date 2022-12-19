using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DTOs
{
    public class BuscarInventarioDTO
    {

        public int Codigo { get; set; }

        public string Cod_Articulo { get; set; }

        public string Descripcion { get; set; }

        public int TipoFiltro { get; set; }

        public string ValorFiltro { get; set; }

        public bool MostrarInhabilitados { get; set; }

        public int Coincidir { get; set; }

    }
}
