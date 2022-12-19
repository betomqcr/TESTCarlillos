using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Inventario
    {
        public Inventario()
        {
            AjusteInventarioDetalles = new HashSet<AjusteInventarioDetalle>();
            ArticulosComprados = new HashSet<ArticulosComprado>();
            ArticulosVentasDevueltos = new HashSet<ArticulosVentasDevuelto>();
            CotizacionDetalles = new HashSet<CotizacionDetalle>();
            Lotes = new HashSet<Lote>();
            VentasDetalles = new HashSet<VentasDetalle>();
        }

        public long Codigo { get; set; }
        public string CodArticulo { get; set; }
        public string Barras { get; set; }
        public string Descripcion { get; set; }
        public double PresentaCant { get; set; }
        public int CodPresentacion { get; set; }
        public int CodMarca { get; set; }
        public string SubFamilia { get; set; }
        public double Minima { get; set; }
        public double PuntoMedio { get; set; }
        public double Maxima { get; set; }
        public double Existencia { get; set; }
        public string SubUbicacion { get; set; }
        public string Observaciones { get; set; }
        public int MonedaCosto { get; set; }
        public double PrecioBase { get; set; }
        public double Fletes { get; set; }
        public double OtrosCargos { get; set; }
        public double Costo { get; set; }
        public int MonedaVenta { get; set; }
        public double Iventa { get; set; }
        public double PrecioA { get; set; }
        public double PrecioB { get; set; }
        public double PrecioC { get; set; }
        public double PrecioD { get; set; }
        public double PrecioPromo { get; set; }
        public bool PromoActiva { get; set; }
        public DateTime PromoInicio { get; set; }
        public DateTime PromoFinaliza { get; set; }
        public double MaxComision { get; set; }
        public double MaxDescuento { get; set; }
        public byte[] Imagen { get; set; }
        public DateTime FechaIngreso { get; set; }
        public bool Servicio { get; set; }
        public bool Inhabilitado { get; set; }
        public int Proveedor { get; set; }
        public double PrecioSugerido { get; set; }
        public double SugeridoIv { get; set; }
        public bool PreguntaPrecio { get; set; }
        public bool Lote { get; set; }
        public bool Consignacion { get; set; }
        public int IdBodega { get; set; }
        public double ExistenciaBodega { get; set; }
        public double MaxInventario { get; set; }
        public double MaxBodega { get; set; }
        public double? CantidadDescarga { get; set; }
        public string CodigoDescarga { get; set; }
        public bool? DescargaOtro { get; set; }
        public int CodPresentOtro { get; set; }
        public double CantidadPresentOtro { get; set; }
        public double? ExistenciaForzada { get; set; }
        public bool? Bloqueado { get; set; }
        public bool? Pantalla { get; set; }
        public bool? Clinica { get; set; }
        public bool? Mascotas { get; set; }
        public bool? Receta { get; set; }
        public bool? Peces { get; set; }
        public bool? Taller { get; set; }
        public string Barras2 { get; set; }
        public string Barras3 { get; set; }
        public double? Apartado { get; set; }
        public bool? Promo3x1 { get; set; }
        public bool? Orden { get; set; }
        public bool? Bonificado { get; set; }
        public string Encargado { get; set; }
        public long Serie { get; set; }
        public bool? Armamento { get; set; }
        public bool? Tienda { get; set; }
        public double? Prestamo { get; set; }
        public bool? Maquinaria { get; set; }
        public bool? ProductosOrganicos { get; set; }
        public long? Rifa { get; set; }
        public bool PromoCon { get; set; }
        public bool PromoCre { get; set; }
        public double? CostoReal { get; set; }
        public bool ValidaExistencia { get; set; }
        public bool Actualizado { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public int IdImpuesto { get; set; }
        public bool ActivarBodega2 { get; set; }
        public double ExistenciaBodega2 { get; set; }
        public bool EnToma { get; set; }
        public bool UsaGalon { get; set; }
        public bool ApicarDescuentoTarjeta { get; set; }
        public bool SoloContado { get; set; }
        public bool SoloConExistencia { get; set; }
        public bool Mag { get; set; }
        public bool SinDecimal { get; set; }
        public string Codcabys { get; set; }
        public long CodigoPrestamo { get; set; }
        public bool? Muestra { get; set; }
        public bool Web { get; set; }
        public bool SoloUsoInterno { get; set; }

        public virtual Presentacione CodPresentacionNavigation { get; set; }
        public virtual Impuesto IdImpuestoNavigation { get; set; }
        public virtual ICollection<AjusteInventarioDetalle> AjusteInventarioDetalles { get; set; }
        public virtual ICollection<ArticulosComprado> ArticulosComprados { get; set; }
        public virtual ICollection<ArticulosVentasDevuelto> ArticulosVentasDevueltos { get; set; }
        public virtual ICollection<CotizacionDetalle> CotizacionDetalles { get; set; }
        public virtual ICollection<Lote> Lotes { get; set; }
        public virtual ICollection<VentasDetalle> VentasDetalles { get; set; }
    }
}
