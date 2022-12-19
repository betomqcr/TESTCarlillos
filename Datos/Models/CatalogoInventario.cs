using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class CatalogoInventario
    {
        public long Codigo { get; set; }
        public string CodArticulo { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Simbolo { get; set; }
        public double PrecioA { get; set; }
        public double ValorCompra { get; set; }
        public double PrecioFinal { get; set; }
        public double? PrecioFinalMag { get; set; }
        public double Existencia { get; set; }
        public double Bodega { get; set; }
        public string Ubicacion { get; set; }
        public string Barras { get; set; }
        public bool Servicio { get; set; }
        public bool Inhabilitado { get; set; }
        public bool? Receta { get; set; }
        public string Barras2 { get; set; }
        public string Barras3 { get; set; }
        public int Idbodega { get; set; }
        public double? Prestamo { get; set; }
        public bool? DescargaOtro { get; set; }
        public bool Consignacion { get; set; }
        public string Codcabys { get; set; }
        public bool Mag { get; set; }
        public int Proveedor { get; set; }
        public bool Muestra { get; set; }
    }
}
