using Datos.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces
{
    public interface IInventariosManagerDA
    {
        Task<ResponseGeneric<DTOs.InventarioDTO>> addInventario(Datos.DTOs.InventarioDTO request);

        Task<ResponseGeneric<DTOs.InventarioDTO>> editInventario(Datos.DTOs.InventarioDTO request);

        Task<ResponseGeneric<int>> getIDInventario(string cod_articulo);

        Task<ResponseGeneric<int>> getIDInventario(string cod_articulo, string descripcion);

        Task<ResponseGeneric<IEnumerable<DTOs.InventarioDTO>>> getInventarioByCodigo(Datos.DTOs.BuscarInventarioDTO request);

        Task<ResponseGeneric<IEnumerable<DTOs.InventarioDTO>>> getInventarioByDescripcion(Datos.DTOs.BuscarInventarioDTO request);

        Task<ResponseGeneric<IEnumerable<DTOs.FilterInventarioDTO>>> getInventarioByFilter(Datos.DTOs.BuscarInventarioDTO request);

        Task<ResponseGeneric<DTOs.InventarioDTO>> getOneInventarioByCodigo(Datos.DTOs.BuscarInventarioDTO request);

        Task<ResponseGeneric<DTOs.InventarioDTO>> disableInventario(int idInventario, string idUsuarioModificacion);

        Task<ResponseGeneric<DTOs.InventarioDTO>> enableInventario(int idInventario, string idUsuarioModificacion);
    }
}
