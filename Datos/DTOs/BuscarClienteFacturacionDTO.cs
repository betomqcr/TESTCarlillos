using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DTOs
{
    public class BuscarClienteFacturacionDTO
    {
        public long Identificacion { get; set; }
        public string Cedula { get; set; }
        public int IdTipoIdentificacion { get; set; }
        public string Nombre { get; set; }
        public string Observaciones { get; set; }
        public string Telefono01 { get; set; }
        public string Direccion { get; set; }
        public string CorreoComprobante { get; set; }
        public string E_Mail { get; set; }
        public bool Anulado { get; set; }
        public string Agente { get; set; }
        public bool Actualizado { get; set; }
        public bool Fallecido { get; set; }
        public bool EnviarRecibo { get; set; }
        public string CorreoRecibo { get; set; }
        public short Tipoprecio { get; set; }
        public double DescuentoEspecial { get; set; }
        public bool Mag { get; set; }
        public string Mensaje { get; set; }
    }
}
