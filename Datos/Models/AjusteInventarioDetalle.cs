using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class AjusteInventarioDetalle
    {
        public long Consecutivo { get; set; }
        public long ConsAjuste { get; set; }
        public long CodArticulo { get; set; }
        public string CodArticulo1 { get; set; }
        public string DescArticulo { get; set; }
        public double Cantidad { get; set; }
        public bool Entrada { get; set; }
        public bool Salida { get; set; }
        public string Observacion { get; set; }
        public string CuentaContable { get; set; }
        public double TotalEntrada { get; set; }
        public double TotalSalida { get; set; }
        public double Existencia { get; set; }
        public double CostoUnit { get; set; }
        public string Cuentacontable1 { get; set; }
        public string Descripcioncuentacontable { get; set; }
        public string Numero { get; set; }
        public long? Gasto { get; set; }
        public bool? Muerte { get; set; }
        public bool Actualizado { get; set; }

        public virtual Inventario CodArticuloNavigation { get; set; }
        public virtual AjusteInventario ConsAjusteNavigation { get; set; }
    }
}
