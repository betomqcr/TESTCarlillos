using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class VistaAbono
    {
        public long IdRecibo { get; set; }
        public long NumRecibo { get; set; }
        public long CodCliente { get; set; }
        public string NombreCliente { get; set; }
        public DateTime Fecha { get; set; }
        public bool Anula { get; set; }
        public int? NumCaja { get; set; }
        public double Monto { get; set; }
        public double SaldoActual { get; set; }
        public double SaldoCuenta { get; set; }
    }
}
