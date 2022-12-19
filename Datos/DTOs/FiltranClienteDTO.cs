using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DTOs
{
    public class FiltranClienteDTO
    {
        public long Identificacion { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Observaciones { get; set; }
        public string Telefono_01 { get; set; }
        public string Telefono_02 { get; set; }
        public string Fax_01 { get; set; }
        public string Fax_02 { get; set; }
        public string E_Mail { get; set; }
        public bool Abierto { get; set; }
        public string Direccion { get; set; }
        public double Impuesto { get; set; }
        public double Max_Credito { get; set; }
        public int Plazo_Credito { get; set; }
        public double Descuento { get; set; }
        public bool Empresa { get; set; }
        public short Tipoprecio { get; set; }
        public bool Sinrestriccion { get; set; }
        public string Agente { get; set; }
        public int CodMonedaCredito { get; set; }
        public bool Cliente_Moroso { get; set; }
        public bool Anulado { get; set; }
        public bool OrdenCompra { get; set; }
        public string CorreoComprobante { get; set; }
        public bool Actualizado { get; set; }
        public double DescuentoEspecial { get; set; }
        public bool Relacionados { get; set; }
        public bool Mag { get; set; }
        public bool EnviarRecibo { get; set; }
        public string CorreoRecibo { get; set; }
        public bool UsoInterno { get; set; }
        public bool Fallecido { get; set; }
        public int IdSucursal { get; set; }
        public int IdTipoIdentificacion { get; set; }
        public string IdUsuarioCreacion { get; set; }
        public bool Estado { get; set; }
    }
}
