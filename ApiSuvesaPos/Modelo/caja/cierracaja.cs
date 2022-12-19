using System;
using System.Collections.Generic;

namespace Modelo
{
    public class cierrecaja
    {
        public int NumeroCierre { get; set; }
        public string Cajera { get; set; }
        public string Nombre { get; set; }
        public int Apertura { get; set; }
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public string NombreUsuario { get; set; }
        public bool Anulado { get; set; }
        public decimal Devoluciones { get; set; }
        public decimal Subtotal { get; set; }
        public decimal TotalSistema { get; set; }
        public decimal Equivalencia { get; set; }
        public decimal EfectivoColones { get; set; }
        public decimal EfectivoDolares { get; set; }
        public decimal TarjetaColones { get; set; }
        public decimal TarjetaDolares { get; set; }
        public decimal Cheques { get; set; }
        public decimal ChequeDol { get; set; }
        public decimal DepositosCol { get; set; }
        public decimal DepositosDol { get; set; }
        public List<Modelo.cierrecaja_detmon> CierreCaja_DetMon { get; set; } = new List<Modelo.cierrecaja_detmon>();
        public List<Modelo.cierrecaja_dettarj> CierreCaja_DetTarj { get; set; } = new List<Modelo.cierrecaja_dettarj>();
    }

    public class cierrecaja_detmon
    {
        public int Id_DetaMoneda { get; set; }
        public int Id_CierreCaja { get; set; }
        public int Id_Moneda { get; set; }
        public decimal MontoSistema { get; set; }
        public decimal MontoCajero { get; set; }
    }

    public class cierrecaja_dettarj
    {
        public int Id_DetalleTarjeta { get; set; }
        public int Id_CierreCaja { get; set; }
        public int Id_TipoTarjeta { get; set; }
        public decimal MontoSistema { get; set; }
        public decimal MontoCajero { get; set; }
    }
}
