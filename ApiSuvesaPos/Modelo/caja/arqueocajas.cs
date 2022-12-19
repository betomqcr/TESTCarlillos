using System;
using System.Collections.Generic;

namespace Modelo
{
    public class arqueocajas
    {
        public long Id { get; set; }
        public decimal EfectivoColones { get; set; }
        public decimal EfectivoDolares { get; set; }
        public decimal TarjetaColones { get; set; }
        public decimal TarjetaDolares { get; set; }
        public decimal Cheques { get; set; }
        public decimal ChequesDol { get; set; }
        public decimal DepositoCol { get; set; }
        public decimal DepositoDol { get; set; }
        public decimal Total { get; set; }
        public int IdApertura { get; set; }
        public DateTime Fecha { get; set; }
        public string Cajero { get; set; }
        public bool Anulado { get; set; }
        public decimal TipoCambioD { get; set; }
        public string Observaciones { get; set; }
        public decimal TarjetaSistema { get; set; }
        public decimal OtrasTarjetas { get; set; }
        public List<Modelo.arqueodeposito> ArqueoDeposito { get; set; } = new List<Modelo.arqueodeposito>();
        public List<Modelo.arqueoefectivo> ArqueoeEectivo { get; set; } = new List<Modelo.arqueoefectivo>();
        public List<Modelo.arqueotarjeta> ArqueoTarjeta { get; set; } = new List<Modelo.arqueotarjeta>();
    }

    public class arqueodeposito
    {
        public int Id { get; set; }
        public int IdArqueo { get; set; }
        public string Banco { get; set; }
        public string Cuenta { get; set; }
        public string Moneda { get; set; }
        public string Numero { get; set; }
        public decimal Monto { get; set; }
        public int IdApertura { get; set; }
        public string Tipo { get; set; }
    }

    public class arqueoefectivo
    {
        public int Id { get; set; }
        public long Id_Arqueo { get; set; }
        public long Id_Denominacion { get; set; }
        public decimal Monto { get; set; }
        public int Cantidad { get; set; }
    }

    public class arqueotarjeta
    {
        public int Id { get; set; }
        public long Id_Arqueo { get; set; }
        public int Id_Tarjeta { get; set; }
        public decimal Monto { get; set; }
    }
}
