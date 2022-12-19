using Dapper;
using Datos.Connection;
using Datos.DTOs;
using Datos.Helpers;
using Datos.Interfaces;
using Datos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Class
{
    public class ClientesManager : IClientesManagerDA
    {
        private readonly IConnectionManager _ConnectionManager;
        private readonly SeePOSContext _entities;

        public ClientesManager(IConnectionManager connectionManager)
        {
            _ConnectionManager = connectionManager;
            _entities = new SeePOSContext();
        }

        public async Task<ResponseGeneric<DTOs.ClienteDTO>> addClientEntry(ClienteDTO request)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<DTOs.ClienteDTO>
                    (
                         sql: "usp_Clientes_AgregarInfo",
                         param: new
                         {
                             request.Cedula,
                             request.Nombre,
                             request.Observaciones,
                             telefono_01 = request.Telefono01,
                             telefono_02 = request.Telefono02,
                             fax_01 = request.Fax01,
                             fax_02 = request.Fax02,
                             e_mail = request.EMail,
                             request.Abierto,
                             request.Direccion,
                             request.Impuesto,
                             max_credito = request.MaxCredito,
                             Plazo_credito = request.PlazoCredito,
                             request.Descuento,
                             request.Empresa,
                             request.Tipoprecio,
                             request.Sinrestriccion,
                             request.Agente,
                             request.CodMonedaCredito,
                             Cliente_Moroso = request.ClienteMoroso,
                             request.Anulado,
                             request.OrdenCompra,
                             request.CorreoComprobante,
                             request.Actualizado,
                             request.DescuentoEspecial,
                             request.Relacionados,
                             request.Mag,
                             request.EnviarRecibo,
                             request.CorreoRecibo,
                             request.UsoInterno,
                             request.Fallecido,
                             request.IdSucursal,
                             request.IdTipoIdentificacion,
                             Estado = true,
                             request.IdUsuarioCreacion
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    return new ResponseGeneric<ClienteDTO>(resultado.FirstOrDefault());
                }
            }
            catch(Exception ex)
            {
                return new ResponseGeneric<ClienteDTO>(ex);
            }

        }

        public async Task<ResponseGeneric<DTOs.ClienteDTO>> editClient(ClienteDTO request)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<DTOs.ClienteDTO>
                    (
                         sql: "usp_Clientes_Editar",
                         param: new
                         {
                             request.Identificacion,
                             request.Cedula,
                             request.Nombre,
                             request.Observaciones,
                             telefono_01 = request.Telefono01,
                             telefono_02 = request.Telefono02,
                             fax_01 = request.Fax01,
                             fax_02 = request.Fax02,
                             e_mail = request.EMail,
                             request.Abierto,
                             request.Direccion,
                             request.Impuesto,
                             max_credito = request.MaxCredito,
                             Plazo_credito = request.PlazoCredito,
                             request.Descuento,
                             request.Empresa,
                             request.Tipoprecio,
                             request.Sinrestriccion,
                             request.Agente,
                             request.CodMonedaCredito,
                             Cliente_Moroso = request.ClienteMoroso,
                             request.Anulado,
                             request.OrdenCompra,
                             request.CorreoComprobante,
                             request.Actualizado,
                             request.DescuentoEspecial,
                             request.Relacionados,
                             request.Mag,
                             request.EnviarRecibo,
                             request.CorreoRecibo,
                             request.UsoInterno,
                             request.Fallecido,
                             request.IdSucursal,
                             request.IdTipoIdentificacion,
                             Estado = true,
                             request.IdUsuarioModificacion
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    return new ResponseGeneric<ClienteDTO>(resultado.FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<ClienteDTO>(ex);
            }
        }

        public async Task<ResponseGeneric<ClienteDTO>> editClientFacturacion(ClienteDTO request)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<DTOs.ClienteDTO>
                    (
                         sql: "usp_Clientes_Editar_Facturacion",
                         param: new
                         {
                             request.Identificacion,
                             telefono_01 = request.Telefono01,
                             e_mail = request.EMail,
                             request.Direccion,
                             request.Tipoprecio,
                             request.Agente,
                             request.Anulado,
                             request.CorreoComprobante,
                             request.Actualizado,
                             request.DescuentoEspecial,
                             request.Mag,
                             request.EnviarRecibo,
                             request.CorreoRecibo,
                             request.Fallecido,
                             request.IdTipoIdentificacion,
                             request.IdUsuarioModificacion
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    return new ResponseGeneric<ClienteDTO>(resultado.FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<ClienteDTO>(ex);
            }
        }

        public async Task<ResponseGeneric<int>> getIDClient(string cedula)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<int>
                    (
                         sql: "[usp_Clientes_Obtener_ID_PorCedula]",
                         param: new
                         {
                            cedula
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

        public async Task<ResponseGeneric<int>> getIDClient(string cedula, string nombre)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<int>
                    (
                         sql: "usp_Clientes_Obtener_ID_PorCedula_PorNombre",
                         param: new
                         {
                             cedula,
                             nombre
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

        public async Task<ResponseGeneric<Models.CorreosComprobantes>> getClientEmails(long id)
        {
            try
            {
                int aplica = 0;
                string[] correos;
                Models.CorreosComprobantes correosComprobantes = new Models.CorreosComprobantes();

                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryMultipleAsync
                    (
                        sql: "usp_Clientes_Obtener_CorreosComprobantes",
                        param: new
                        {
                            identificacion = id
                        },
                        commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    aplica = resultado.Read<int>().First();
                    correosComprobantes.idCliente = id;

                    if( aplica == 1)
                    {
                        correos = resultado.Read<string>().First().Split(";");
                        List<Models.Correos> emails = new List<Correos>();
                        foreach(string correo in correos)
                        {
                            emails.Add(new Correos()
                            {
                                correo = correo
                            });
                        }
                        correosComprobantes.correos = emails;
                    } 
                    else
                    {
                        correosComprobantes.mensaje = "No Aplica";
                    }

                    return new ResponseGeneric<Models.CorreosComprobantes>(correosComprobantes);
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<Models.CorreosComprobantes>(ex);
            }
        }

        public async Task<ResponseGeneric<CorreosComprobantes>> putClientEmails(CorreosComprobantes correos)
        {
            try
            {
                string correoComprobantes = "";

                foreach (Correos correo in correos.correos)
                {
                    if (correoComprobantes.Equals(""))
                    {
                        correoComprobantes += correo.correo;
                    } 
                    else
                    {
                        correoComprobantes += ";" + correo.correo;
                    }
                    
                }

                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<int>
                    (
                         sql: "usp_Clientes_Editar_CorreosComprobantes",
                         param: new
                         {
                             identificacion = correos.idCliente,
                             correosComprobantes = correoComprobantes
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    if (resultado.FirstOrDefault() == 0)
                    {
                        correos.mensaje = "Cliente no encontrado";
                    }

                    return new ResponseGeneric<Models.CorreosComprobantes>(correos);
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<Models.CorreosComprobantes>(ex);
            }
        }

        public async Task<ResponseGeneric<DTOs.BuscarClienteFacturacionDTO>> existClientFacturacion(string cedula)
        {
            try
            {
                int aplica = 0;
                DTOs.BuscarClienteFacturacionDTO buscarClienteFacturacionDTO = new BuscarClienteFacturacionDTO();

                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryMultipleAsync
                    (
                         sql: "usp_Clientes_Existe_Facturacion",
                         param: new
                         {
                             cedula
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    aplica =  resultado.Read<int>().First();

                    if( aplica == 1 )
                    {
                        buscarClienteFacturacionDTO = resultado.Read<DTOs.BuscarClienteFacturacionDTO>().First();
                    }
                    else
                    {
                        buscarClienteFacturacionDTO.Mensaje = "No aplica";
                    }

                    return new ResponseGeneric<BuscarClienteFacturacionDTO>(buscarClienteFacturacionDTO);

                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<BuscarClienteFacturacionDTO>(ex);
            }
        }

        public async Task<ResponseGeneric<IEnumerable<FiltranClienteDTO>>> getClientByCedula(BuscarClienteDTO request)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<DTOs.FiltranClienteDTO>
                    (
                         sql: "usp_Clientes_Obtener_Cedula",
                         param: new
                         {
                             request.Cedula
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    return new ResponseGeneric<IEnumerable<FiltranClienteDTO>>(resultado);
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<IEnumerable<FiltranClienteDTO>>(ex);
            }
        }

        public async Task<ResponseGeneric<IEnumerable<FiltranClienteDTO>>> getClientByNombre(BuscarClienteDTO request)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<DTOs.FiltranClienteDTO>
                    (
                         sql: "usp_Clientes_Obtener_Nombre",
                         param: new
                         {
                             request.Nombre
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    return new ResponseGeneric<IEnumerable<FiltranClienteDTO>>(resultado);
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<IEnumerable<FiltranClienteDTO>>(ex);
            }
        }
        
        public async Task<ResponseGeneric<IEnumerable<FiltranClienteDTO>>> getClientByFiltro(BuscarClienteDTO request)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<DTOs.FiltranClienteDTO>
                    (
                         sql: "usp_Clientes_Obtener_Filtro",
                         param: new
                         {
                             request.Cedula,
                             request.Nombre
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    return new ResponseGeneric<IEnumerable<FiltranClienteDTO>>(resultado);
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<IEnumerable<FiltranClienteDTO>>(ex);
            }
        }

        public async Task<ResponseGeneric<FiltranClienteDTO>> disableClient(int idCliente, string idUsuarioModificacion)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<DTOs.FiltranClienteDTO>
                    (
                         sql: "usp_Clientes_Desactivar",
                         param: new
                         {
                             idCliente,
                             idUsuarioModificacion
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    return new ResponseGeneric<FiltranClienteDTO>(resultado.FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<FiltranClienteDTO>(ex);
            }
        }

        public async Task<ResponseGeneric<FiltranClienteDTO>> enableClient(int idCliente, string idUsuarioModificacion)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<DTOs.FiltranClienteDTO>
                    (
                         sql: "usp_Clientes_Activar",
                         param: new
                         {
                             idCliente,
                             idUsuarioModificacion
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    return new ResponseGeneric<FiltranClienteDTO>(resultado.FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<FiltranClienteDTO>(ex);
            }
        }

    }
}
