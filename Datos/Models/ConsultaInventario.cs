using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ConsultaInventario
    {
        public string CodArticulo { get; set; }
        public string Descripcion { get; set; }
        public double Costo { get; set; }
        public double Existencia { get; set; }
        public string DescSubFamilia { get; set; }
        public string Familia { get; set; }
        public string Ubicacion { get; set; }
        public int MonedaCosto { get; set; }
        public double ValorCompra { get; set; }
        public bool Servicio { get; set; }
        public bool Inhabilitado { get; set; }
        public bool Consignacion { get; set; }
        public double Minima { get; set; }
        public double PuntoMedio { get; set; }
        public double Maxima { get; set; }
    }
}
