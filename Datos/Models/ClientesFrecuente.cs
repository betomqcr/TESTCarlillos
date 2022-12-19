using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ClientesFrecuente
    {
        public long Identificacion { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Observaciones { get; set; }
        public string Telefono01 { get; set; }
        public string Telefono02 { get; set; }
        public string Fax01 { get; set; }
        public string Fax02 { get; set; }
        public string EMail { get; set; }
        public string Direccion { get; set; }
        public short Tipoprecio { get; set; }
        public string Usuario { get; set; }
        public string Nombreusuario { get; set; }
        public bool Anulado { get; set; }
        public bool? Esempresa { get; set; }
        public string TipoCliente { get; set; }
    }
}
