using Datos.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioSuvesa.Interfaces
{
    public interface IInventarioManagerBL
    {
        Task<ResponseGeneric<Datos.DTOs.InventarioDTO>> addInventario(Datos.DTOs.InventarioDTO request);

        Task<ResponseGeneric<Datos.DTOs.InventarioDTO>> editInventario(Datos.DTOs.InventarioDTO request);

        Task<ResponseGeneric<int>> getIDInventario(string cod_articulo);

        Task<ResponseGeneric<int>> getIDInventario(string cod_articulo, string descripcion);

        Task<ResponseGeneric<IEnumerable<Datos.DTOs.InventarioDTO>>> getInventarioByCodigo(Datos.DTOs.BuscarInventarioDTO request);

        Task<ResponseGeneric<IEnumerable<Datos.DTOs.InventarioDTO>>> getInventarioByDescripcion(Datos.DTOs.BuscarInventarioDTO request);

        Task<ResponseGeneric<IEnumerable<Datos.DTOs.FilterInventarioDTO>>> getInventarioByFilter(Datos.DTOs.BuscarInventarioDTO request);

        Task<ResponseGeneric<Datos.DTOs.InventarioDTO>> getOneInventarioByCodigo(Datos.DTOs.BuscarInventarioDTO request);

        Task<ResponseGeneric<Datos.DTOs.InventarioDTO>> disableInventario(Datos.DTOs.EliminarInventarioDTO request);

        Task<ResponseGeneric<Datos.DTOs.InventarioDTO>> enableInventario(Datos.DTOs.EliminarInventarioDTO request);
    }
}
