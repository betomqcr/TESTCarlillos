using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class MovimientosBodegaDetalle
    {
        public int IdDetalle { get; set; }
        public long BoletaMovimiento { get; set; }
        public string Codigo { get; set; }
        public string CodArticulo { get; set; }
        public string Descripcion { get; set; }
        public double Cantidad { get; set; }
        public bool? TipoEntrada { get; set; }
        public bool TipoSalida { get; set; }
        public string Numero { get; set; }
        public long? ExistenciaForzada { get; set; }
        public long? ExistVeteForzada { get; set; }

        public virtual MovimientosBodega BoletaMovimientoNavigation { get; set; }
    }
}
