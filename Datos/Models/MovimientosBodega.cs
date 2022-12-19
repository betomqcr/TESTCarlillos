using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class MovimientosBodega
    {
        public MovimientosBodega()
        {
            MovimientosBodegaDetalles = new HashSet<MovimientosBodegaDetalle>();
        }

        public long BoletaMovimiento { get; set; }
        public int Bodega { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaEntrada { get; set; }
        public string Referencia { get; set; }
        public string Usuario { get; set; }
        public bool Anulado { get; set; }
        public string Cliente { get; set; }

        public virtual Bodega BodegaNavigation { get; set; }
        public virtual ICollection<MovimientosBodegaDetalle> MovimientosBodegaDetalles { get; set; }
    }
}
