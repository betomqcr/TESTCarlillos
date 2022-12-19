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
    public class SubUbicacionesManagerDA : ISubUbicacionesManagerDA
    {
        private readonly IConnectionManager _ConnectionManager;

        public SubUbicacionesManagerDA(IConnectionManager connectionManager)
        {
            _ConnectionManager = connectionManager;
        }

        public async Task<ResponseGeneric<IEnumerable<SubUbicacionesFilterInventarioDTO>>> getSubUbicacionesFilterInventarios()
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<DTOs.SubUbicacionesFilterInventarioDTO>
                    (
                         sql: "usp_Obtener_SubUbicaciones_Inventario",
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );
                    
                    return new ResponseGeneric<IEnumerable<SubUbicacionesFilterInventarioDTO>>(resultado);
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<IEnumerable<SubUbicacionesFilterInventarioDTO>>(ex);
            }
        }
    }
}
