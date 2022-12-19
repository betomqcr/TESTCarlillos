using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class TipoTarjetum
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Moneda { get; set; }
        public string Observaciones { get; set; }
        public string CuentaCxc { get; set; }
        public string NombreCxc { get; set; }
        public string CuentaIv { get; set; }
        public string NombreIv { get; set; }
        public string CuentaComision { get; set; }
        public string NombreComision { get; set; }
        public double PorcentajeRetencion { get; set; }
        public double PorcentajeComision { get; set; }
        public string NombreCuenta { get; set; }
        public string CuentaContable { get; set; }
    }
}
