using Datos.DTOs;
using Datos.Helpers;
using Datos.Interfaces;
using Datos.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using NegocioSuvesa.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NegocioSuvesa.Class
{
    public class ClienteManager : IClienteManagerBL
    {
        private readonly IClientesManagerDA _clientesManager;
        private IValidaciones _validaciones;
        private readonly IConfiguration _configuration;

        static HttpClient client = new HttpClient();

        public ClienteManager(IClientesManagerDA clientesManager, IValidaciones validaciones, IConfiguration configuration)
        {
            _clientesManager = clientesManager;
            _configuration = configuration;
            _validaciones = validaciones;
        }

        public async Task<ResponseGeneric<ClienteDTO>> addClientEntry(ClienteDTO request)
        {
            // Validaciones Cedula
            if (_validaciones.isEmpty(request.Cedula) || !_validaciones.isOnlyNumeric(request.Cedula))
            {
                return new ResponseGeneric<ClienteDTO>("Error: Cédula requerida o incorrecta");
            }

            // Validaciones Nombre 
            if (_validaciones.isEmpty(request.Nombre) || !_validaciones.isOnlyLetter(request.Nombre))
            {
                return new ResponseGeneric<ClienteDTO>("Error: Nombre requerido o incorrecto");
            }

            // Validaciones Telefonos 
            if (_validaciones.isEmpty(request.Telefono01) || !_validaciones.isOnlyNumeric(request.Telefono01))
            {
                return new ResponseGeneric<ClienteDTO>("Error: Telefono requerido o incorrecto");
            }

            // Validaciones Email 
            if (_validaciones.isEmpty(request.EMail) || !_validaciones.isEmail(request.EMail))
            {
                return new ResponseGeneric<ClienteDTO>("Error: Correo electronico requerido 0 incorrecto");
            }

            // Validaciones CorreoComprobante 
            if (_validaciones.isEmpty(request.CorreoComprobante))
            {
                return new ResponseGeneric<ClienteDTO>("Error: Correo Comprobante requerido o incorrecto");
            }

            // Validaciones Direccion 
            if (_validaciones.isEmpty(request.Direccion))
            {
                return new ResponseGeneric<ClienteDTO>("Error: Direccion requerida");
            }

            return await _clientesManager.addClientEntry(request);
        }

        public async Task<ResponseGeneric<ClienteDTO>> editClient(ClienteDTO request)
        {
            // Validaciones Cedula
            if (_validaciones.isEmpty(request.Cedula) || !_validaciones.isOnlyNumeric(request.Cedula))
            {
                return new ResponseGeneric<ClienteDTO>("Error: Cédula incorrecta");
            }

            // Validaciones Nombre 
            if (_validaciones.isEmpty(request.Nombre) || !_validaciones.isOnlyLetter(request.Nombre))
            {
                return new ResponseGeneric<ClienteDTO>("Error: Nombre incorrecto");
            }

            // Validaciones Email 
            if (_validaciones.isEmpty(request.EMail) || !_validaciones.isEmail(request.EMail))
            {
                return new ResponseGeneric<ClienteDTO>("Error: Correo electronico incorrecto");
            }

            // Validaciones CorreoComprobante 
            if (_validaciones.isEmpty(request.CorreoComprobante))
            {
                return new ResponseGeneric<ClienteDTO>("Error: Correo Comprobante incorrecto");
            }

            // Validaciones Direccion 
            if (_validaciones.isEmpty(request.Direccion))
            {
                return new ResponseGeneric<ClienteDTO>("Error: Direccion requerida");
            }

            return await _clientesManager.editClient(request);
        }

        public async Task<ResponseGeneric<ClienteDTO>> editClientFacturacion(ClienteDTO request)
        {

            // Validaciones Email 
            if (_validaciones.isEmpty(request.EMail) || !_validaciones.isEmail(request.EMail))
            {
                return new ResponseGeneric<ClienteDTO>("Error: Correo electronico incorrecto");
            }

            // Validaciones CorreoComprobante 
            if (_validaciones.isEmpty(request.CorreoComprobante))
            {
                return new ResponseGeneric<ClienteDTO>("Error: Correo Comprobante incorrecto");
            }

            // Validaciones Direccion 
            if (_validaciones.isEmpty(request.Direccion))
            {
                return new ResponseGeneric<ClienteDTO>("Error: Direccion requerida");
            }

            return await _clientesManager.editClientFacturacion(request);
        }

        public async Task<ResponseGeneric<IEnumerable<FiltranClienteDTO>>> getClientByCedula(BuscarClienteDTO request)
        {
            // Validaciones Cedula
            if (_validaciones.isEmpty(request.Cedula) || !_validaciones.isOnlyNumeric(request.Cedula))
            {
                return new ResponseGeneric<IEnumerable<FiltranClienteDTO>>("Error: Cédula incorrecta");
            }

            return await _clientesManager.getClientByCedula(request);
        }

        public async Task<ResponseGeneric<IEnumerable<FiltranClienteDTO>>> getClientByFiltro(BuscarClienteDTO request)
        {
            // Validaciones Cedula
            if (_validaciones.isEmpty(request.Cedula) || !_validaciones.isOnlyNumeric(request.Cedula))
            {
                return new ResponseGeneric<IEnumerable<FiltranClienteDTO>>("Error: Cédula incorrecta");
            }

            // Validaciones Nombre
            if (_validaciones.isEmpty(request.Nombre) || !_validaciones.isOnlyLetter(request.Nombre))
            {
                return new ResponseGeneric<IEnumerable<FiltranClienteDTO>>("Error: Nombre incorrecta");
            }

            return await _clientesManager.getClientByFiltro(request);
        }

        public async Task<ResponseGeneric<IEnumerable<FiltranClienteDTO>>> getClientByNombre(BuscarClienteDTO request)
        {
            // Validaciones Cedula
            if (_validaciones.isEmpty(request.Nombre) || !_validaciones.isOnlyLetter(request.Nombre))
            {
                return new ResponseGeneric<IEnumerable<FiltranClienteDTO>>("Error: Nombre incorrecta");
            }

            return await _clientesManager.getClientByNombre(request);
        }

        public async Task<ResponseGeneric<int>> getIDClient(string cedula)
        {
            return await _clientesManager.getIDClient(cedula);
        }

        public async Task<ResponseGeneric<int>> getIDClient(string cedula, string nombre)
        {
            return await _clientesManager.getIDClient(cedula, nombre);
        }

        public async Task<ResponseGeneric<CorreosComprobantes>> getEmailsClient(long id)
        {
            return await _clientesManager.getClientEmails(id);
        }

        public async Task<ResponseGeneric<CorreosComprobantes>> putClientEmails(CorreosComprobantes lista)
        {
            return await _clientesManager.putClientEmails(lista);
        }

        public async Task<ResponseGeneric<FiltranClienteDTO>> disableClient(EliminarClienteDTO request)
        {
            // Validaciones Cedula
            if (_validaciones.isEmpty(request.Cedula) || !_validaciones.isOnlyNumeric(request.Cedula))
            {
                return new ResponseGeneric<FiltranClienteDTO>("Error: Cédula incorrecta");
            }

            // Validaciones Nombre
            if (_validaciones.isEmpty(request.Nombre) || !_validaciones.isOnlyLetter(request.Nombre))
            {
                return new ResponseGeneric<FiltranClienteDTO>("Error: Nombre incorrecta");
            }

            ResponseGeneric<int> idCliente = await getIDClient(request.Cedula, request.Nombre);

            return await _clientesManager.disableClient(idCliente.Responses, request.IdUsuarioModificacion);
        }

        public async Task<ResponseGeneric<FiltranClienteDTO>> enableClient(EliminarClienteDTO request)
        {
            // Validaciones Cedula
            if (_validaciones.isEmpty(request.Cedula) || !_validaciones.isOnlyNumeric(request.Cedula))
            {
                return new ResponseGeneric<FiltranClienteDTO>("Error: Cédula incorrecta");
            }

            // Validaciones Nombre
            if (_validaciones.isEmpty(request.Nombre) || !_validaciones.isOnlyLetter(request.Nombre))
            {
                return new ResponseGeneric<FiltranClienteDTO>("Error: Nombre incorrecta");
            }

            ResponseGeneric<int> idCliente = await getIDClient(request.Cedula, request.Nombre);

            return await _clientesManager.enableClient(idCliente.Responses, request.IdUsuarioModificacion);
        }

        public async Task<ResponseGeneric<BuscarClienteFacturacionDTO>> existClientFacturacion(BuscarClienteDTO request)
        {

            ResponseHaciendaPersonas responseHacienda = new ResponseHaciendaPersonas();
            string responseHaciendaString = "";
            string regExp = @"^[0-9]{1}[0-9]{4}[0-9]{4}$";

            // Validaciones Cedula
            if (_validaciones.isEmpty(request.Cedula) || !_validaciones.isOnlyNumeric(request.Cedula))
            {
                return new ResponseGeneric<BuscarClienteFacturacionDTO>("Error: Cédula requerida o incorrecta");
            }

            if (!Regex.IsMatch(request.Cedula, regExp))
            {
                return new ResponseGeneric<BuscarClienteFacturacionDTO>("Error: Cédula requerida o incorrecta");
            }


            ResponseGeneric<BuscarClienteFacturacionDTO> data = await _clientesManager.existClientFacturacion(request.Cedula);

            if(data.Responses.Mensaje != null)
            {
                HttpResponseMessage response = await client.GetAsync($"{_configuration["URLHaciendaPersonas"]}{request.Cedula}");
                    
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    responseHaciendaString = await response.Content.ReadAsStringAsync();
                    responseHacienda = JsonConvert.DeserializeObject<ResponseHaciendaPersonas>(responseHaciendaString);

                    data.Responses.Cedula = request.Cedula;
                    data.Responses.IdTipoIdentificacion = obtenerTipoIdentificacion(responseHacienda.TipoIdentificacion);
                    data.Responses.Nombre = responseHacienda.Nombre;
                    data.Responses.Mensaje = "Cliente no registrado";
                } 
                else
                {
                    data.Responses.Mensaje = "Cliente no registrado";
                }
            }

            return data;
        }

        private int obtenerTipoIdentificacion(string tipoIdentificacionHacienda)
        {
            int tipoIdentificacion = 0;

            switch ( tipoIdentificacionHacienda)
            {
                case "01":
                    tipoIdentificacion = 2;
                    break;

                case "02":
                    tipoIdentificacion = 3;
                    break;

                case "03":
                    tipoIdentificacion = 4;
                    break;
            }

            return tipoIdentificacion;
        }
        
    }
}
