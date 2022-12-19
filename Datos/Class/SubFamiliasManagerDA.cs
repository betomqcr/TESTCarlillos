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
    public class SubFamiliasManagerDA : ISubFamiliasManagerDA
    {
        private readonly IConnectionManager _ConnectionManager;

        public SubFamiliasManagerDA(IConnectionManager connectionManager)
        {
            _ConnectionManager = connectionManager;
        }

        public async Task<ResponseGeneric<IEnumerable<SubFamiliasFilterInventarioDTO>>> getSubFamiliasFilterInventarios()
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<DTOs.SubFamiliasFilterInventarioDTO>
                    (
                         sql: "usp_Obtener_SubFamilias_Inventario",
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    return new ResponseGeneric<IEnumerable<SubFamiliasFilterInventarioDTO>>(resultado);
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<IEnumerable<SubFamiliasFilterInventarioDTO>>(ex);
            }
        }
    }
}
