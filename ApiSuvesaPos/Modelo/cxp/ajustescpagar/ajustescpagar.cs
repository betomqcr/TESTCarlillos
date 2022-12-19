using System;

namespace Modelo
{
    public class ajustescpagar
    {
        public long ID_Ajuste { get; set; }
        public long AjusteNo { get; set; }
        public char Tipo { get; set; }
        public int Cod_Proveedor { get; set; }
        public string Nombre_Proveedor { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Saldo_Prev { get; set; }
        public decimal Monto { get; set; }
        public decimal Saldo_Act { get; set; }
        public string Observaciones { get; set; }
        public bool Anula { get; set; }
        public string Cod_Usuario { get; set; }
        public bool Contabilizado { get; set; }
        public int Cod_Moneda { get; set; }
        public long Asiento { get; set; }
        public DateTime FechaEntrada { get; set; }
    }
}

