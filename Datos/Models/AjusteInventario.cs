using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class AjusteInventario
    {
        public AjusteInventario()
        {
            AjusteInventarioDetalles = new HashSet<AjusteInventarioDetalle>();
        }

        public long Consecutivo { get; set; }
        public DateTime Fecha { get; set; }
        public bool Anula { get; set; }
        public string Cedula { get; set; }
        public double TotalEntrada { get; set; }
        public double TotalSalida { get; set; }
        public double SaldoAjuste { get; set; }
        public double? Asiento { get; set; }
        public bool? Contabilizado { get; set; }
        public int IdSucursal { get; set; }

        public virtual Sucursale IdSucursalNavigation { get; set; }
        public virtual ICollection<AjusteInventarioDetalle> AjusteInventarioDetalles { get; set; }
    }
}
