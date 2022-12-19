using Dapper;
using Datos.Connection;
using Datos.DTOs;
using Datos.Helpers;
using Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Class
{
    public class InventariosManagerDA : IInventariosManagerDA
    {
        private readonly IConnectionManager _ConnectionManager;

        public InventariosManagerDA(IConnectionManager connectionManager)
        {
            _ConnectionManager = connectionManager;
        }

        public async Task<ResponseGeneric<InventarioDTO>> addInventario(InventarioDTO request)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<DTOs.InventarioDTO>
                    (
                         sql: "usp_Inventarios_Agregar",
                         param: new
                         {
                             request.Cod_Articulo,
                             request.Barras,
                             request.Descripcion,
                             request.PresentaCant,
                             request.CodPresentacion,   
                             request.CodMarca,
                             request.SubFamilia,
                             request.Minima,
                             request.PuntoMedio,
                             request.Maxima,
                             request.Existencia,
                             request.SubUbicacion,
                             request.Observaciones,
                             request.MonedaCosto,
                             request.PrecioBase,
                             request.Fletes,
                             request.OtrosCargos,
                             request.Costo,
                             request.MonedaVenta,
                             request.IVenta,
                             request.Precio_A,
                             request.Precio_B,
                             request.Precio_C,
                             request.Precio_D,
                             request.Precio_Promo,
                             request.Promo_Activa,
                             request.Promo_Inicio,
                             request.Promo_Finaliza,
                             request.Max_Comision,
                             request.Max_Descuento,
                             request.Servicio,
                             request.Inhabilitado,
                             request.Proveedor,
                             request.Precio_Sugerido,
                             request.SugeridoIV,
                             request.PreguntaPrecio,
                             request.Lote,
                             request.Consignacion,
                             request.Id_Bodega,
                             request.ExistenciaBodega,
                             request.MAX_Inventario,
                             request.MAX_Bodega,
                             request.CantidadDescarga,
                             request.CodigoDescarga,
                             request.DescargaOtro,
                             request.Cod_PresentOtro,
                             request.CantidadPresentOtro,
                             request.ExistenciaForzada,
                             request.bloqueado,
                             request.pantalla,
                             request.clinica,
                             request.mascotas,
                             request.receta,
                             request.peces,
                             request.taller,
                             request.barras2,
                             request.barras3,
                             request.Apartado,
                             request.promo3x1,
                             request.orden,
                             request.bonificado,
                             request.encargado,
                             request.serie,
                             request.armamento,
                             request.tienda,
                             request.prestamo,
                             request.maquinaria,
                             request.productos_organicos,
                             request.rifa,
                             request.PromoCON,
                             request.PromoCRE,
                             request.CostoReal,
                             request.ValidaExistencia,
                             request.Actualizado,
                             request.Id_Impuesto,
                             request.ActivarBodega2,
                             request.ExistenciaBodega2,
                             request.EnToma,
                             request.UsaGalon,
                             request.ApicarDescuentoTarjeta,
                             request.SoloContado,
                             request.SoloConExistencia,
                             request.MAG,
                             request.SinDecimal,
                             request.CODCABYS,
                             request.CodigoPrestamo,
                             request.Muestra,
                             request.Web,
                             request.SoloUsoInterno,
                             Estado = true,
                             request.IdUsuarioCreacion
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    return new ResponseGeneric<InventarioDTO>(resultado.FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<InventarioDTO>(ex);
            }
        }
        
        public async Task<ResponseGeneric<InventarioDTO>> editInventario(InventarioDTO request)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<DTOs.InventarioDTO>
                    (
                         sql: "usp_Inventarios_Editar",
                         param: new
                         {
                             request.Codigo,
                             request.Cod_Articulo,
                             request.Barras,
                             request.Descripcion,
                             request.PresentaCant,
                             request.CodPresentacion,
                             request.CodMarca,
                             request.SubFamilia,
                             request.Minima,
                             request.PuntoMedio,
                             request.Maxima,
                             request.Existencia,
                             request.SubUbicacion,
                             request.Observaciones,
                             request.MonedaCosto,
                             request.PrecioBase,
                             request.Fletes,
                             request.OtrosCargos,
                             request.Costo,
                             request.MonedaVenta,
                             request.IVenta,
                             request.Precio_A,
                             request.Precio_B,
                             request.Precio_C,
                             request.Precio_D,
                             request.Precio_Promo,
                             request.Promo_Activa,
                             request.Promo_Inicio,
                             request.Promo_Finaliza,
                             request.Max_Comision,
                             request.Max_Descuento,
                             request.Servicio,
                             request.Inhabilitado,
                             request.Proveedor,
                             request.Precio_Sugerido,
                             request.SugeridoIV,
                             request.PreguntaPrecio,
                             request.Lote,
                             request.Consignacion,
                             request.Id_Bodega,
                             request.ExistenciaBodega,
                             request.MAX_Inventario,
                             request.MAX_Bodega,
                             request.CantidadDescarga,
                             request.CodigoDescarga,
                             request.DescargaOtro,
                             request.Cod_PresentOtro,
                             request.CantidadPresentOtro,
                             request.ExistenciaForzada,
                             request.bloqueado,
                             request.pantalla,
                             request.clinica,
                             request.mascotas,
                             request.receta,
                             request.peces,
                             request.taller,
                             request.barras2,
                             request.barras3,
                             request.Apartado,
                             request.promo3x1,
                             request.orden,
                             request.bonificado,
                             request.encargado,
                             request.serie,
                             request.armamento,
                             request.tienda,
                             request.prestamo,
                             request.maquinaria,
                             request.productos_organicos,
                             request.rifa,
                             request.PromoCON,
                             request.PromoCRE,
                             request.CostoReal,
                             request.ValidaExistencia,
                             request.Actualizado,
                             request.Id_Impuesto,
                             request.ActivarBodega2,
                             request.ExistenciaBodega2,
                             request.EnToma,
                             request.UsaGalon,
                             request.ApicarDescuentoTarjeta,
                             request.SoloContado,
                             request.SoloConExistencia,
                             request.MAG,
                             request.SinDecimal,
                             request.CODCABYS,
                             request.CodigoPrestamo,
                             request.Muestra,
                             request.Web,
                             request.SoloUsoInterno,
                             Estado = true,
                             request.IdUsuarioModificacion
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    return new ResponseGeneric<InventarioDTO>(resultado.FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<InventarioDTO>(ex);
            }
        }

        public async Task<ResponseGeneric<int>> getIDInventario(string cod_articulo)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<int>
                    (
                         sql: "usp_Inventarios_Obtener_ID",
                         param: new
                         {
                             Cod_Articulo = cod_articulo
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    return new ResponseGeneric<int>(resultado.FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<int>(ex);
            }
        }

        public async Task<ResponseGeneric<int>> getIDInventario(string cod_articulo, string descripcion)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<int>
                    (
                         sql: "usp_Inventarios_Obtener_ID_PorCodigo_PorDescripcion",
                         param: new
                         {
                             Cod_Articulo = cod_articulo,
                             descripcion
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    return new ResponseGeneric<int>(resultado.FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<int>(ex);
            }
        }

        public async Task<ResponseGeneric<IEnumerable<InventarioDTO>>> getInventarioByCodigo(BuscarInventarioDTO request)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<DTOs.InventarioDTO>
                    (
                         sql: "usp_Inventarios_Obtener_Codigo",
                         param: new
                         {
                             request.Cod_Articulo,
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    return new ResponseGeneric<IEnumerable<InventarioDTO>>(resultado);
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<IEnumerable<InventarioDTO>>(ex);
            }
        }

        public async Task<ResponseGeneric<IEnumerable<InventarioDTO>>> getInventarioByDescripcion(BuscarInventarioDTO request)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<DTOs.InventarioDTO>
                    (
                         sql: "usp_Inventarios_Obtener_Descripcion",
                         param: new
                         {
                             request.Descripcion,
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    return new ResponseGeneric<IEnumerable<InventarioDTO>>(resultado);
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<IEnumerable<InventarioDTO>>(ex);
            }
        }

        public async Task<ResponseGeneric<IEnumerable<FilterInventarioDTO>>> getInventarioByFilter(BuscarInventarioDTO request)
        {
            try
            {
                //Realiza la conexión con la base de datos
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<DTOs.FilterInventarioDTO>
                    (
                         sql: "usp_Inventarios_Filtrar",
                         param: new
                         {
                             request.TipoFiltro,
                             request.ValorFiltro,
                             request.MostrarInhabilitados,
                             request.Coincidir
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    return new ResponseGeneric<IEnumerable<FilterInventarioDTO>>(resultado);
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<IEnumerable<FilterInventarioDTO>>(ex);
            }
        }

        public async Task<ResponseGeneric<InventarioDTO>> disableInventario(int idInventario, string idUsuarioModificacion)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<DTOs.InventarioDTO>
                    (
                         sql: "usp_Inventarios_Desactivar",
                         param: new
                         {
                             idInventario,
                             idUsuarioModificacion
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    return new ResponseGeneric<InventarioDTO>(resultado.FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<InventarioDTO>(ex);
            }
        }

        public async Task<ResponseGeneric<InventarioDTO>> enableInventario(int idInventario, string idUsuarioModificacion)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<DTOs.InventarioDTO>
                    (
                         sql: "usp_Inventarios_Activar",
                         param: new
                         {
                             idInventario,
                             idUsuarioModificacion
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    return new ResponseGeneric<InventarioDTO>(resultado.FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<InventarioDTO>(ex);
            }
        }

        public async Task<ResponseGeneric<InventarioDTO>> getOneInventarioByCodigo(BuscarInventarioDTO request)
        {
            try
            {
                //Realiza la conexión con la base de datos
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<DTOs.InventarioDTO>
                    (
                         sql: "usp_Inventarios_Obtener_CodigoPrincipal",
                         param: new
                         {
                             request.Codigo
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    return new ResponseGeneric<InventarioDTO>(resultado.FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<InventarioDTO>(ex);
            }
        }
    }
}
