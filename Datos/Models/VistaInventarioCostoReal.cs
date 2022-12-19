using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class VistaInventarioCostoReal
    {
        public long Codigo { get; set; }
        public string CodArticulo { get; set; }
        public string Descripcion { get; set; }
        public double PrecioBase { get; set; }
        public double PrecioA { get; set; }
        public double? CostoReal { get; set; }
        public double CantidadVendida { get; set; }
        public double DescargaDeOtro { get; set; }
        public double CantidadComprada { get; set; }
        public bool? DescargaOtro { get; set; }
        public int CodPresentOtro { get; set; }
        public double CantidadPresentOtro { get; set; }
        public double? CantidadDescarga { get; set; }
        public string CodigoDescarga { get; set; }
        public double PresentaCant { get; set; }
    }
}
