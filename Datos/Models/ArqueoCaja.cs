using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ArqueoCaja
    {
        public ArqueoCaja()
        {
            ArqueoDepositos = new HashSet<ArqueoDeposito>();
            ArqueoEfectivos = new HashSet<ArqueoEfectivo>();
            ArqueoTarjeta = new HashSet<ArqueoTarjetum>();
        }

        public long Id { get; set; }
        public double EfectivoColones { get; set; }
        public double EfectivoDolares { get; set; }
        public double TarjetaColones { get; set; }
        public double TarjetaDolares { get; set; }
        public double Cheques { get; set; }
        public double ChequesDol { get; set; }
        public double DepositoCol { get; set; }
        public double DepositoDol { get; set; }
        public double Total { get; set; }
        public int IdApertura { get; set; }
        public DateTime Fecha { get; set; }
        public string Cajero { get; set; }
        public bool Anulado { get; set; }
        public double TipoCambioD { get; set; }
        public string Observaciones { get; set; }
        public double TarjetaSistema { get; set; }
        public double OtrasTarjetas { get; set; }

        public virtual ICollection<ArqueoDeposito> ArqueoDepositos { get; set; }
        public virtual ICollection<ArqueoEfectivo> ArqueoEfectivos { get; set; }
        public virtual ICollection<ArqueoTarjetum> ArqueoTarjeta { get; set; }
    }
}
