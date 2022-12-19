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
    public class ArticulosRelacionadosManagerDA : IArticulosRelacionadosManagerDA
    {
        private readonly IConnectionManager _ConnectionManager;

        public ArticulosRelacionadosManagerDA(IConnectionManager connectionManager)
        {
            _ConnectionManager = connectionManager;
        }

        public async Task<ResponseGeneric<ArticulosRelacionadosDTO>> addArticulosRelacionadosEntry(ArticulosRelacionadosDTO request)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<DTOs.ArticulosRelacionadosDTO>
                    (
                         sql: "usp_ArticulosRelacionados_Agregar",
                         param: new
                         {
                             request.CodigoPrincipal,
                             request.Codigo,
                             request.CodArticulo,
                             request.Descripcion,
                             request.Cantidad,
                             Estado = true,
                             request.IdUsuarioCreacion
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    return new ResponseGeneric<ArticulosRelacionadosDTO>(resultado.FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<ArticulosRelacionadosDTO>(ex);
            }
        }

        public async Task<ResponseGeneric<ArticulosRelacionadosDTO>> disableArticulosRelacionados(ArticulosRelacionadosDTO request)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<DTOs.ArticulosRelacionadosDTO>
                    (
                         sql: "usp_ArticulosRelacionados_Desactivar",
                         param: new
                         {
                             request.Id
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    return new ResponseGeneric<ArticulosRelacionadosDTO>(resultado.FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<ArticulosRelacionadosDTO>(ex);
            }
        }

        public async Task<ResponseGeneric<IEnumerable<ArticulosRelacionadosDTO>>> getArticulosRelacionadosByCodigoPrincipal(ArticulosRelacionadosDTO request)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<DTOs.ArticulosRelacionadosDTO>
                    (
                         sql: "usp_ArticulosRelacionados_Obtener_CodigoPrincipal",
                         param: new
                         {
                             request.CodigoPrincipal
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    return new ResponseGeneric<IEnumerable<ArticulosRelacionadosDTO>>(resultado);
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<IEnumerable<ArticulosRelacionadosDTO>>(ex);
            }
        }
    }
}
