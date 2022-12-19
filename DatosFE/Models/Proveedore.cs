using System;
using System.Collections.Generic;

#nullable disable

namespace DatosFE.Models
{
    public partial class Proveedore
    {
        public Proveedore()
        {
            Compras = new HashSet<Compra>();
            MensajeReceptors = new HashSet<MensajeReceptor>();
        }

        public int CodigoProv { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Contacto { get; set; }
        public string TelefonoCont { get; set; }
        public string Observaciones { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Fax1 { get; set; }
        public string Fax2 { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public double MontoCredito { get; set; }
        public int Plazo { get; set; }
        public bool CostoTotal { get; set; }
        public bool ImpIncluido { get; set; }
        public int PedidosMes { get; set; }
        public double UtilidadInventario { get; set; }
        public bool UtilidadFija { get; set; }
        public string CuentaContable { get; set; }
        public string DescripcionCuentaContable { get; set; }
        public bool Actualizado { get; set; }
        public bool Inhabilitado { get; set; }
        public bool Fec { get; set; }
        public string TipoProveedor { get; set; }
        public decimal IdProvincia { get; set; }
        public decimal IdCanton { get; set; }
        public decimal IdDistrito { get; set; }
        public string OtrasSenas { get; set; }
        public string CodigoActividad { get; set; }
        public string CorreoElectronico { get; set; }
        public bool Serie { get; set; }
        public bool Bloqueado { get; set; }

        public virtual ICollection<Compra> Compras { get; set; }
        public virtual ICollection<MensajeReceptor> MensajeReceptors { get; set; }
    }
}
