using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Ajustescpagar
    {
        public Ajustescpagar()
        {
            DetalleAjustescPagars = new HashSet<DetalleAjustescPagar>();
        }

        public long IdAjuste { get; set; }
        public long? AjusteNo { get; set; }
        public string Tipo { get; set; }
        public int? CodProveedor { get; set; }
        public string NombreProveedor { get; set; }
        public DateTime? Fecha { get; set; }
        public double? SaldoPrev { get; set; }
        public double? Monto { get; set; }
        public double? SaldoAct { get; set; }
        public string Observaciones { get; set; }
        public bool? Anula { get; set; }
        public string CodUsuario { get; set; }
        public bool? Contabilizado { get; set; }
        public int? CodMoneda { get; set; }
        public long? Asiento { get; set; }
        public DateTime FechaEntrada { get; set; }
        public int IdSucursal { get; set; }

        public virtual Proveedore CodProveedorNavigation { get; set; }
        public virtual ICollection<DetalleAjustescPagar> DetalleAjustescPagars { get; set; }
    }
}
