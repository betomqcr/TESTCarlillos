using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Abonoccobrar
    {
        public Abonoccobrar()
        {
            DetalleAbonoccobrars = new HashSet<DetalleAbonoccobrar>();
        }

        public long IdRecibo { get; set; }
        public long NumRecibo { get; set; }
        public long CodCliente { get; set; }
        public string NombreCliente { get; set; }
        public double SaldoCuenta { get; set; }
        public double Monto { get; set; }
        public double SaldoActual { get; set; }
        public DateTime Fecha { get; set; }
        public string Observaciones { get; set; }
        public bool Anula { get; set; }
        public string CedUsuario { get; set; }
        public bool Contabilizado { get; set; }
        public long Asiento { get; set; }
        public int CodMoneda { get; set; }
        public string Cheque { get; set; }
        public int? NumCaja { get; set; }
        public string Banco { get; set; }
        public decimal NumApertura { get; set; }
        public string EstadoEnvio { get; set; }
        public int IdSucursal { get; set; }

        public virtual ICollection<DetalleAbonoccobrar> DetalleAbonoccobrars { get; set; }
    }
}
