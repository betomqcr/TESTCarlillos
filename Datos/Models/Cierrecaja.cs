using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Cierrecaja
    {
        public Cierrecaja()
        {
            CierreCajaDetMons = new HashSet<CierreCajaDetMon>();
            CierreCajaDetTarjs = new HashSet<CierreCajaDetTarj>();
        }

        public int NumeroCierre { get; set; }
        public string Cajera { get; set; }
        public string Nombre { get; set; }
        public int Apertura { get; set; }
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public string NombreUsuario { get; set; }
        public bool Anulado { get; set; }
        public double Devoluciones { get; set; }
        public double Subtotal { get; set; }
        public double TotalSistema { get; set; }
        public double Equivalencia { get; set; }
        public double EfectivoColones { get; set; }
        public double EfectivoDolares { get; set; }
        public double TarjetaColones { get; set; }
        public double TarjetaDolares { get; set; }
        public double Cheques { get; set; }
        public double ChequeDol { get; set; }
        public double DepositosCol { get; set; }
        public double DepositosDol { get; set; }

        public virtual ICollection<CierreCajaDetMon> CierreCajaDetMons { get; set; }
        public virtual ICollection<CierreCajaDetTarj> CierreCajaDetTarjs { get; set; }
    }
}
