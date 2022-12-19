using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;
namespace Datos.Class
{
public class Inventario
    {


        private SeePOSContext entities;

        public Inventario()
        {
            entities = new SeePOSContext();
        }

        public int Crear(Models.Inventario inventario) // crear carta apartir de objeto de creacion
        {
            try
            {
                entities.Inventarios.Add(inventario);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Models.Inventario> Buscar(bool porId, string filtro) //obtener lista CartasdeExoneracion 
        {
            try
            {
                List<Models.Inventario> result;

                if (porId == false)
                {
                    //busca por la descripcion
                    var temp = from c in entities.Inventarios
                                   // usar un like
                               select c;

                    result = temp.ToList<Models.Inventario>();
                }
                else
                {
                    //busca por el id de la tabla
                    var temp = from c in entities.Inventarios
                               where c.Codigo == Convert.ToInt32(filtro) //convertir el datos de string a long
                               select c;
                    result = temp.ToList<Models.Inventario>();
                }

                if (result.Count > 0)
                {
                    return result;
                }
                else
                {
                    return result = null;
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Editar(long id, Models.Inventario inventario)
        {
            try
            {
                var p = entities.Inventarios.Find(id);
                Models.Inventario viejo = p;

                if (viejo != null)
                {
                    viejo.CodArticulo = inventario.CodArticulo;
                    viejo.Barras = inventario.Barras;
                    viejo.Descripcion = inventario.Descripcion;
                    viejo.PresentaCant = inventario.PresentaCant;
                    viejo.CodPresentacion = inventario.CodPresentacion;
                    viejo.CodMarca = inventario.CodMarca;
                    viejo.SubFamilia = inventario.SubFamilia;
                    viejo.Minima = inventario.Minima;
                    viejo.PuntoMedio = inventario.PuntoMedio;
                    viejo.Maxima = inventario.Maxima;
                    viejo.Existencia = inventario.Existencia;
                    viejo.SubUbicacion = inventario.SubUbicacion;
                    viejo.Observaciones = inventario.Observaciones;
                    viejo.MonedaCosto = inventario.MonedaCosto;
                    viejo.PrecioBase = inventario.PrecioBase;
                    viejo.Fletes = inventario.Fletes;
                    viejo.OtrosCargos = inventario.OtrosCargos;
                    viejo.Costo = inventario.Costo;
                    viejo.MonedaVenta = inventario.MonedaVenta;
                    viejo.Iventa = inventario.Iventa;
                    viejo.PrecioA = inventario.PrecioA;
                    viejo.PrecioB = inventario.PrecioB;
                    viejo.PrecioC = inventario.PrecioC;
                    viejo.PrecioD = inventario.PrecioD;
                    viejo.PrecioPromo = inventario.PrecioPromo;
                    viejo.PromoActiva = inventario.PromoActiva;
                    viejo.PromoInicio = inventario.PromoInicio;
                    viejo.PromoFinaliza = inventario.PromoFinaliza;
                    viejo.MaxComision = inventario.MaxComision;
                    viejo.MaxDescuento = inventario.MaxDescuento;
                    viejo.Imagen = inventario.Imagen;
                    viejo.FechaIngreso = inventario.FechaIngreso;
                    viejo.Servicio = inventario.Servicio;
                    viejo.Inhabilitado = inventario.Inhabilitado;
                    viejo.Proveedor = inventario.Proveedor;
                    viejo.PrecioSugerido = inventario.PrecioSugerido;
                    viejo.SugeridoIv = inventario.SugeridoIv;
                    viejo.PreguntaPrecio = inventario.PreguntaPrecio;
                    viejo.Lote = inventario.Lote;
                    viejo.Consignacion = inventario.Consignacion;
                    viejo.IdBodega = inventario.IdBodega;
                    viejo.ExistenciaBodega = inventario.ExistenciaBodega;
                    viejo.MaxInventario = inventario.MaxInventario;
                    viejo.MaxBodega = inventario.MaxBodega;
                    viejo.CantidadDescarga = inventario.CantidadDescarga;
                    viejo.CodigoDescarga = inventario.CodigoDescarga;
                    viejo.DescargaOtro = inventario.DescargaOtro;
                    viejo.CodPresentOtro = inventario.CodPresentOtro;
                    viejo.CantidadPresentOtro = inventario.CantidadPresentOtro;
                    viejo.ExistenciaForzada = inventario.ExistenciaForzada;
                    viejo.Bloqueado = inventario.Bloqueado;
                    viejo.Pantalla = inventario.Pantalla;
                    viejo.Clinica = inventario.Clinica;
                    viejo.Mascotas = inventario.Mascotas;
                    viejo.Receta = inventario.Receta;
                    viejo.Peces = inventario.Peces;
                    viejo.Taller = inventario.Taller;
                    viejo.Barras2 = inventario.Barras2;
                    viejo.Barras3 = inventario.Barras3;
                    viejo.Apartado = inventario.Apartado;
                    viejo.Promo3x1 = inventario.Promo3x1;
                    viejo.Orden = inventario.Orden;
                    viejo.Bonificado = inventario.Bonificado;
                    viejo.Encargado = inventario.Encargado;
                    viejo.Serie = inventario.Serie;
                    viejo.Armamento = inventario.Armamento;
                    viejo.Tienda = inventario.Tienda;
                    viejo.Prestamo = inventario.Prestamo;
                    viejo.Maquinaria = inventario.Maquinaria;
                    viejo.ProductosOrganicos = inventario.ProductosOrganicos;
                    viejo.Rifa = inventario.Rifa;
                    viejo.PromoCon = inventario.PromoCon;
                    viejo.PromoCre = inventario.PromoCre;
                    viejo.CostoReal = inventario.CostoReal;
                    viejo.ValidaExistencia = inventario.ValidaExistencia;
                    viejo.Actualizado = inventario.Actualizado;
                    viejo.FechaActualizacion = inventario.FechaActualizacion;
                    viejo.IdImpuesto = inventario.IdImpuesto;
                    viejo.ActivarBodega2 = inventario.ActivarBodega2;
                    viejo.ExistenciaBodega2 = inventario.ExistenciaBodega2;
                    viejo.EnToma = inventario.EnToma;
                    viejo.UsaGalon = inventario.UsaGalon;
                    viejo.ApicarDescuentoTarjeta = inventario.ApicarDescuentoTarjeta;
                    viejo.SoloContado = inventario.SoloContado;
                    viejo.SoloConExistencia = inventario.SoloConExistencia;
                    viejo.Mag = inventario.Mag;
                    viejo.SinDecimal = inventario.SinDecimal;
                    viejo.Codcabys = inventario.Codcabys;
                    viejo.CodigoPrestamo = inventario.CodigoPrestamo;
                    viejo.Muestra = inventario.Muestra;
                    viejo.Web = inventario.Web;
                    viejo.SoloUsoInterno = inventario.SoloUsoInterno;

                    entities.Entry(viejo).State = EntityState.Modified;

                    return entities.SaveChanges();
                }
                else
                {
                    return 0;// no se encotro el registro solicitado.
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int Borrar(long id) // borrar Actividad apartir del id Actividad


        {
            try
            {
                var p = entities.Inventarios.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


    }
}
