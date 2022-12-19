using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Abonocpagar
    {
        public Abonocpagar()
        {
            DetalleAbonocpagars = new HashSet<DetalleAbonocpagar>();
        }

        public long IdAbonocpagar { get; set; }
        public long Documento { get; set; }
        public string TipoDocumento { get; set; }
        public string CuentaBancaria { get; set; }
        public long CodigoBanco { get; set; }
        public double SaldoCuenta { get; set; }
        public double Monto { get; set; }
        public double SaldoActual { get; set; }
        public DateTime Fecha { get; set; }
        public bool Contabilizado { get; set; }
        public string Recibo { get; set; }
        public string CedulaUsuario { get; set; }
        public int CodProveedor { get; set; }
        public bool Anulado { get; set; }
        public int CodMoneda { get; set; }
        public double TipoCambio { get; set; }
        public string MontoLetras { get; set; }
        public long CuentaDestino { get; set; }
        public DateTime FechaEntrada { get; set; }
        public string Observaciones { get; set; }
        public int IdSucursal { get; set; }

        public virtual Proveedore CodProveedorNavigation { get; set; }
        public virtual ICollection<DetalleAbonocpagar> DetalleAbonocpagars { get; set; }
    }
}
