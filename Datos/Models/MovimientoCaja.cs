using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class MovimientoCaja
    {
        public long Id { get; set; }
        public bool? Entrada { get; set; }
        public bool Salida { get; set; }
        public double Monto { get; set; }
        public int CodMoneda { get; set; }
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Observaciones { get; set; }
        public bool Anulado { get; set; }
        public long NumApertura { get; set; }
        public double TipoCambio { get; set; }
        public int IdSucursal { get; set; }
    }
}
