using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Log
    {
        public decimal Id { get; set; }
        public string IdTerminal { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoTransaccion { get; set; }
        public decimal Factura { get; set; }
        public double Monto { get; set; }
        public string CodigoRespueta { get; set; }
        public string DescripcionRespuesta { get; set; }
        public string Autorizacion { get; set; }
        public string Referencia { get; set; }
        public string IdTransaccion { get; set; }
        public string TituloTag { get; set; }
        public string Tags { get; set; }
        public decimal IdApertura { get; set; }
        public bool Anulado { get; set; }
        public string NumeroTarjeta { get; set; }
    }
}
