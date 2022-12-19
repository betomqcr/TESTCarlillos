using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public class CorreosComprobantes
    {
        public long idCliente { set; get; }

        public string mensaje { get; set; }

        public List<Correos> correos { set; get; }
    }
}
