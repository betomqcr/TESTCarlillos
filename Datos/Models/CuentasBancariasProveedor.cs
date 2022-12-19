using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class CuentasBancariasProveedor
    {
        public int IdCuenta { get; set; }
        public int CodigoProv { get; set; }
        public string TipoCuenta { get; set; }
        public string Banco { get; set; }
        public int CodMoneda { get; set; }
        public string NumCuenta { get; set; }
        public string MonedaNombre { get; set; }

        public virtual Proveedore CodigoProvNavigation { get; set; }
    }
}
