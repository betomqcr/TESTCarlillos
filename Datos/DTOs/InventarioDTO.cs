using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DTOs
{
    public class InventarioDTO
    {
        public long Codigo { get; set; }
        public string Cod_Articulo { get; set; }
        public string Barras { get; set; }
        public string Descripcion { get; set; }
        public float PresentaCant { get; set; }
        public int CodPresentacion { get; set; }
        public int CodMarca { get; set; }
        public string SubFamilia { get; set; }
        public float Minima { get; set; }
        public float PuntoMedio { get; set; }
        public float Maxima { get; set; }
        public float Existencia { get; set; }
        public string SubUbicacion { get; set; }
        public string Observaciones { get; set; }
        public int MonedaCosto { get; set; }
        public float PrecioBase { get; set; }
        public float Fletes { get; set; }
        public float OtrosCargos { get; set; }
        public float Costo { get; set; }
        public int MonedaVenta { get; set; }
        public float IVenta { get; set; }
        public float Precio_A { get; set; }
        public float Precio_B { get; set; }
        public float Precio_C { get; set; }
        public float Precio_D { get; set; }
        public float Precio_Promo { get; set; } 
        public bool Promo_Activa { get; set; }
        public Nullable<DateTime> Promo_Inicio { get; set; } = null;
        public Nullable<DateTime> Promo_Finaliza { get; set; } = null;
        public float Max_Comision { get; set; }
        public float Max_Descuento { get; set; }
        public bool Servicio { get; set; }
        public bool Inhabilitado { get; set; }
        public int Proveedor { get; set; }
        public float  Precio_Sugerido { get; set; }
        public float SugeridoIV { get; set; }
        public bool PreguntaPrecio { get; set; }
        public bool Lote { get; set; }
        public bool Consignacion { get; set; }
        public int Id_Bodega { get; set; }
        public float ExistenciaBodega { get; set; }
        public float MAX_Inventario { get; set; }
        public float MAX_Bodega { get; set; }
        public float CantidadDescarga { get; set; }
        public string CodigoDescarga { get; set; }
        public bool DescargaOtro { get; set; }
        public int Cod_PresentOtro { get; set; }
        public float CantidadPresentOtro { get; set; }
        public float ExistenciaForzada { get; set; }
        public bool bloqueado { get; set; }
        public bool pantalla { get; set; }
        public bool clinica { get; set; }
        public bool mascotas { get; set; }
        public bool receta { get; set; }
        public bool peces { get; set; }
        public bool taller { get; set; }
        public string barras2 { get; set; }
        public string barras3 { get; set; }
        public float Apartado { get; set; }
        public bool promo3x1 { get; set; }
        public bool orden { get; set; }
        public bool bonificado { get; set; }
        public string encargado { get; set; }
        public long serie { get; set; }
        public bool armamento { get; set; }
        public bool tienda { get; set; }
        public float prestamo { get; set; }
        public bool maquinaria { get; set; }
        public bool productos_organicos { get; set; }
        public long rifa { get; set; }
        public bool PromoCON { get; set; }
        public bool PromoCRE { get; set; }
        public float CostoReal { get; set; }
        public bool ValidaExistencia { get; set; }
        public bool Actualizado { get; set; }
        public int Id_Impuesto { get; set; }
        public bool ActivarBodega2 { get; set; }
        public float ExistenciaBodega2 { get; set; }
        public bool EnToma { get; set; }
        public bool UsaGalon { get; set; }
        public bool ApicarDescuentoTarjeta { get; set; }
        public bool SoloContado { get; set; }
        public bool SoloConExistencia { get; set; }
        public bool MAG { get; set; }
        public bool SinDecimal { get; set; }
        public string CODCABYS { get; set; }
        public long CodigoPrestamo { get; set; }
        public bool Muestra { get; set; }
        public bool Web { get; set; }
        public bool SoloUsoInterno { get; set; }
        public bool Estado { get; set; }
        public string IdUsuarioCreacion { get; set; }
        public string IdUsuarioModificacion { get; set; }

    }
}
