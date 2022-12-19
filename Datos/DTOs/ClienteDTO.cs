

using System.Collections.Generic;

namespace Datos.DTOs
{
    public class ClienteDTO
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
        public bool Abierto { get; set; }
        public string Direccion { get; set; }
        public double Impuesto { get; set; }
        public double MaxCredito { get; set; }
        public int PlazoCredito { get; set; }
        public double Descuento { get; set; }
        public bool Empresa { get; set; }
        public short Tipoprecio { get; set; }
        public bool Sinrestriccion { get; set; }
        public string Agente { get; set; }
        public int CodMonedaCredito { get; set; }
        public bool ClienteMoroso { get; set; }
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
        public string IdUsuarioModificacion { get; set; }

    }
}
