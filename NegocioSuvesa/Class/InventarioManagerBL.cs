using Datos.DTOs;
using Datos.Helpers;
using Datos.Interfaces;
using NegocioSuvesa.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioSuvesa.Class
{
    public class InventarioManagerBL : IInventarioManagerBL
    {

        private readonly IInventariosManagerDA _inventarioManager;
        private IValidaciones _validaciones;

        public InventarioManagerBL(IInventariosManagerDA inventarioManager, IValidaciones validaciones)
        {
            _inventarioManager = inventarioManager;
            _validaciones = validaciones;
        }

        public async Task<ResponseGeneric<InventarioDTO>> addInventario(InventarioDTO request)
        {
            // Validaciones Cod_Articulo
            if (_validaciones.isEmpty(request.Cod_Articulo) || _validaciones.hasSpecialCharacters(request.Cod_Articulo))
            {
                return new ResponseGeneric<InventarioDTO>("Error: Cod Articulo requerido o incorrecto");
            }

            // Validaciones Barras
            if (_validaciones.isEmpty(request.Barras) || !_validaciones.isOnlyNumeric(request.Barras))
            {
                return new ResponseGeneric<InventarioDTO>("Error: Barras requerido o incorrecto");
            }

            // Validaciones Descripcion
            if (_validaciones.isEmpty(request.Descripcion))
            {
                return new ResponseGeneric<InventarioDTO>("Error: Descripcion requerida");
            }

            // Validaciones PresentaCant
            if (request.PresentaCant == 0)
            {
                return new ResponseGeneric<InventarioDTO>("Error: Debe indicar una Cantidad de Presentacion");
            }

            // Validaciones CodPresentacion
            if (request.CodPresentacion == 0)
            {
                return new ResponseGeneric<InventarioDTO>("Error: Debe seleccionar un tipo de Presentacion");
            }

            // Validaciones CodMarca
            if (request.CodMarca == 0)
            {
                return new ResponseGeneric<InventarioDTO>("Error: Debe seleccionar una Marca");
            }

            // Validaciones SubFamilia
            if (_validaciones.isEmpty(request.SubFamilia) || request.SubFamilia.Equals("Seleccione..."))
            {
                return new ResponseGeneric<InventarioDTO>("Error: SubFamilia requerida");
            }

            // Validaciones SubUbicacion
            if (_validaciones.isEmpty(request.SubUbicacion) || request.SubUbicacion.Equals("Seleccione..."))
            {
                return new ResponseGeneric<InventarioDTO>("Error: SubUbicacion requerida");
            }

            // Validaciones MonedaCosto
            if (request.MonedaCosto == 0)
            {
                return new ResponseGeneric<InventarioDTO>("Error: Debe indicar una Moneda de Costo");
            }

            // Validaciones PrecioBase
            if (request.PrecioBase == 0)
            {
                return new ResponseGeneric<InventarioDTO>("Error: Debe indicar un Precio Base");
            }

            // Validaciones MonedaVenta
            if (request.MonedaVenta == 0)
            {
                return new ResponseGeneric<InventarioDTO>("Error: Debe indicar una Moneda de Venta");
            }

            // Validaciones IVenta
            if (request.IVenta == 0)
            {
                return new ResponseGeneric<InventarioDTO>("Error: Debe indicar un Impuesto de Venta");
            }

            // Validaciones Precio_A
            if (request.Precio_A == 0)
            {
                return new ResponseGeneric<InventarioDTO>("Error: Debe indicar al menos el Precia A");
            }

            // Validaciones id_impuesto
            if (request.Id_Impuesto == 0)
            {
                return new ResponseGeneric<InventarioDTO>("Error: Debe indicar un Impuesto");
            }

            // Validaciones CODCABYS
            if (_validaciones.isEmpty(request.CODCABYS) || !_validaciones.isOnlyNumeric(request.CODCABYS))
            {
                return new ResponseGeneric<InventarioDTO>("Error: CODCABYS requerido o incorrecto");
            }

            return await _inventarioManager.addInventario(request);
        }

        public async Task<ResponseGeneric<InventarioDTO>> editInventario(InventarioDTO request)
        {
            // Validaciones Cod_Articulo
            if (_validaciones.isEmpty(request.Cod_Articulo) || _validaciones.hasSpecialCharacters(request.Cod_Articulo))
            {
                return new ResponseGeneric<InventarioDTO>("Error: Cod Articulo requerido o incorrecto");
            }

            // Validaciones Barras
            if (_validaciones.isEmpty(request.Barras) || !_validaciones.isOnlyNumeric(request.Barras))
            {
                return new ResponseGeneric<InventarioDTO>("Error: Barras requerido o incorrecto");
            }

            // Validaciones Descripcion
            if (_validaciones.isEmpty(request.Descripcion))
            {
                return new ResponseGeneric<InventarioDTO>("Error: Descripcion requerida");
            }

            // Validaciones PresentaCant
            if (request.PresentaCant == 0)
            {
                return new ResponseGeneric<InventarioDTO>("Error: Debe indicar una Cantidad de Presentacion");
            }

            // Validaciones CodPresentacion
            if (request.CodPresentacion == 0)
            {
                return new ResponseGeneric<InventarioDTO>("Error: Debe seleccionar un tipo de Presentacion");
            }

            // Validaciones CodMarca
            if (request.CodMarca == 0)
            {
                return new ResponseGeneric<InventarioDTO>("Error: Debe seleccionar una Marca");
            }

            // Validaciones SubFamilia
            if (_validaciones.isEmpty(request.SubFamilia) || request.SubFamilia.Equals("Seleccione..."))
            {
                return new ResponseGeneric<InventarioDTO>("Error: SubFamilia requerida");
            }

            // Validaciones SubUbicacion
            if (_validaciones.isEmpty(request.SubUbicacion) || request.SubUbicacion.Equals("Seleccione..."))
            {
                return new ResponseGeneric<InventarioDTO>("Error: SubUbicacion requerida");
            }

            // Validaciones MonedaCosto
            if (request.MonedaCosto == 0)
            {
                return new ResponseGeneric<InventarioDTO>("Error: Debe indicar una Moneda de Costo");
            }

            // Validaciones PrecioBase
            if (request.PrecioBase == 0)
            {
                return new ResponseGeneric<InventarioDTO>("Error: Debe indicar un Precio Base");
            }

            // Validaciones MonedaVenta
            if (request.MonedaVenta == 0)
            {
                return new ResponseGeneric<InventarioDTO>("Error: Debe indicar una Moneda de Venta");
            }

            // Validaciones IVenta
            if (request.IVenta == 0)
            {
                return new ResponseGeneric<InventarioDTO>("Error: Debe indicar un Impuesto de Venta");
            }

            // Validaciones Precio_A
            if (request.Precio_A == 0)
            {
                return new ResponseGeneric<InventarioDTO>("Error: Debe indicar al menos el Precia A");
            }

            // Validaciones id_impuesto
            if (request.Id_Impuesto == 0)
            {
                return new ResponseGeneric<InventarioDTO>("Error: Debe indicar un Impuesto");
            }

            // Validaciones CODCABYS
            if (_validaciones.isEmpty(request.CODCABYS) || !_validaciones.isOnlyNumeric(request.CODCABYS))
            {
                return new ResponseGeneric<InventarioDTO>("Error: CODCABYS requerido o incorrecto");
            }

            return await _inventarioManager.editInventario(request);
        }

        public async Task<ResponseGeneric<int>> getIDInventario(string cod_articulo)
        {
            return await _inventarioManager.getIDInventario(cod_articulo);
        }

        public async Task<ResponseGeneric<int>> getIDInventario(string cod_articulo, string descripcion)
        {
            return await _inventarioManager.getIDInventario(cod_articulo, descripcion);
        }

        public async Task<ResponseGeneric<IEnumerable<InventarioDTO>>> getInventarioByCodigo(BuscarInventarioDTO request)
        {
            return await _inventarioManager.getInventarioByCodigo(request);
        }

        public async Task<ResponseGeneric<IEnumerable<InventarioDTO>>> getInventarioByDescripcion(BuscarInventarioDTO request)
        {
            return await _inventarioManager.getInventarioByDescripcion(request);
        }

        public async Task<ResponseGeneric<IEnumerable<FilterInventarioDTO>>> getInventarioByFilter(BuscarInventarioDTO request)
        {
            return await _inventarioManager.getInventarioByFilter(request);
        }

        public async Task<ResponseGeneric<InventarioDTO>> disableInventario(EliminarInventarioDTO request)
        {
            ResponseGeneric<int> idInventario = await getIDInventario(request.Cod_Articulo, request.Descripcion);

            return await _inventarioManager.disableInventario(idInventario.Responses, request.IdUsuarioModificacion);
        }

        public async Task<ResponseGeneric<InventarioDTO>> enableInventario(EliminarInventarioDTO request)
        {
            ResponseGeneric<int> idInventario = await getIDInventario(request.Cod_Articulo, request.Descripcion);

            return await _inventarioManager.enableInventario(idInventario.Responses, request.IdUsuarioModificacion);
        }

        public async Task<ResponseGeneric<InventarioDTO>> getOneInventarioByCodigo(BuscarInventarioDTO request)
        {
            return await _inventarioManager.getOneInventarioByCodigo(request);
        }
    }
}
