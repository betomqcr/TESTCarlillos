using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Modelo
{
    public class inventario
    {
        public int Codigo { get; set; }
        public string Cod_Articulo { get; set; }
        public string Barras { get; set; }
        public string Descripcion { get; set; }
        public decimal PresentaCant { get; set; }
        public int CodPresentacion { get; set; }
        public int CodMarca { get; set; }
        public string SubFamilia { get; set; }
        public decimal Minima { get; set; }
        public decimal PuntoMedio { get; set; }
        public decimal Maxima { get; set; }
        public decimal Existencia { get; set; }
        public string SubUbicacion { get; set; }
        public string Observaciones { get; set; }
        public int MonedaCosto { get; set; }
        public decimal PrecioBase { get; set; }
        public decimal Fletes { get; set; }
        public decimal OtrosCargos { get; set; }
        public decimal Costo { get; set; }
        public int MonedaVenta { get; set; }
        public decimal IVenta { get; set; }
        public decimal Precio_A { get; set; }
        public decimal Precio_B { get; set; }
        public decimal Precio_C { get; set; }
        public decimal Precio_D { get; set; }
        public decimal Precio_Promo { get; set; }
        public bool Promo_Activa { get; set; }
        public DateTime Promo_Inicio { get; set; }
        public DateTime Promo_Finaliza { get; set; }
        public decimal Max_Comision { get; set; }
        public decimal Max_Descuento { get; set; }
        // Public Property Imagen As image
        public DateTime FechaIngreso { get; set; }
        public bool Servicio { get; set; }
        public bool Inhabilitado { get; set; }
        public int Proveedor { get; set; }
        public decimal Precio_Sugerido { get; set; }
        public decimal SugeridoIV { get; set; }
        public bool PreguntaPrecio { get; set; }
        public bool Lote { get; set; }
        public bool Consignacion { get; set; }
        public int Id_Bodega { get; set; }
        public decimal ExistenciaBodega { get; set; }
        public decimal MAX_Inventario { get; set; }
        public decimal MAX_Bodega { get; set; }
        public decimal CantidadDescarga { get; set; }
        public string CodigoDescarga { get; set; }
        public bool DescargaOtro { get; set; }
        public int Cod_PresentOtro { get; set; }
        public decimal CantidadPresentOtro { get; set; }
        public decimal ExistenciaForzada { get; set; }
        public bool bloqueado { get; set; }
        public bool pantalla { get; set; }
        public bool clinica { get; set; }
        public bool mascotas { get; set; }
        public bool receta { get; set; }
        public bool peces { get; set; }
        public bool taller { get; set; }
        public string barras2 { get; set; }
        public string barras3 { get; set; }
        public decimal Apartado { get; set; }
        public bool promo3x1 { get; set; }
        public bool orden { get; set; }
        public bool bonificado { get; set; }
        public string encargado { get; set; }
        public int serie { get; set; }
        public bool armamento { get; set; }
        public bool tienda { get; set; }
        public decimal prestamo { get; set; }
        public bool maquinaria { get; set; }
        public bool productos_organicos { get; set; }
        public int rifa { get; set; }
        public bool PromoCON { get; set; }
        public bool PromoCRE { get; set; }
        public decimal CostoReal { get; set; }
        public bool ValidaExistencia { get; set; }
        public bool Actualizado { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public int Id_Impuesto { get; set; }
        public bool ActivarBodega2 { get; set; }
        public decimal ExistenciaBodega2 { get; set; }
        public bool EnToma { get; set; }
        public bool UsaGalon { get; set; }
        public bool ApicarDescuentoTarjeta { get; set; }
        public bool SoloContado { get; set; }
        public bool SoloConExistencia { get; set; }
        public bool MAG { get; set; }
        public bool SinDecimal { get; set; }
        public string CODCABYS { get; set; }
        public int CodigoPrestamo { get; set; }
        public bool Muestra { get; set; }
        public bool SoloUsoInterno { get; set; }

        public List<serie> Serie { get; set; } = new List<serie>();
        public List<articulosrelacionados> ArticulosRelacionados { get; set; } = new List<articulosrelacionados>();
    }
}
