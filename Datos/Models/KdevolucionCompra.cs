using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class KdevolucionCompra
    {
        public long Consecutivo { get; set; }
        public long Codigo { get; set; }
        public string Descripcion { get; set; }
        public long Documento { get; set; }
        public string Tipo { get; set; }
        public double ExistAnt { get; set; }
        public double Cantidad { get; set; }
        public double ExistAct { get; set; }
        public double CostoUnit { get; set; }
        public double CostoMov { get; set; }
        public int CodProveedor { get; set; }
        public int CodCliente { get; set; }
        public int CodMoneda { get; set; }
        public double TipoCambio { get; set; }
        public string Observaciones { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
