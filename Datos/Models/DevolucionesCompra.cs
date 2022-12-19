using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class DevolucionesCompra
    {
        public DevolucionesCompra()
        {
            ArticulosComprasDevueltos = new HashSet<ArticulosComprasDevuelto>();
        }

        public long Devolucion { get; set; }
        public long IdFacturaCompra { get; set; }
        public double SaldoAntFact { get; set; }
        public double SubTotalGravado { get; set; }
        public double SubTotalExcento { get; set; }
        public double Descuento { get; set; }
        public double Impuesto { get; set; }
        public double Monto { get; set; }
        public DateTime Fecha { get; set; }
        public bool Contabilizado { get; set; }
        public double Asiento { get; set; }
        public bool Anulado { get; set; }
        public string CedulaUsuario { get; set; }
        public int CodMoneda { get; set; }
        public string NombrePro { get; set; }
        public bool ContaInventario { get; set; }
        public double AsientoInventario { get; set; }
        public DateTime FechaEntrada { get; set; }
        public int IdSucursal { get; set; }

        public virtual ICollection<ArticulosComprasDevuelto> ArticulosComprasDevueltos { get; set; }
    }
}
