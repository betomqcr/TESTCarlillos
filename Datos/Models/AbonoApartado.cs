using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class AbonoApartado
    {
        public AbonoApartado()
        {
            AbonoApartadosdetalles = new HashSet<AbonoApartadosdetalle>();
        }

        public long IdAbonoapartado { get; set; }
        public int CodCliente { get; set; }
        public string NombreCliente { get; set; }
        public double SaldoCuenta { get; set; }
        public double Monto { get; set; }
        public double SaldoActual { get; set; }
        public DateTime Fecha { get; set; }
        public string Observaciones { get; set; }
        public bool Anula { get; set; }
        public string CedUsuario { get; set; }
        public int CodMoneda { get; set; }
        public long NumRecibo { get; set; }
        public int IdSucursal { get; set; }

        public virtual ICollection<AbonoApartadosdetalle> AbonoApartadosdetalles { get; set; }
    }
}
