using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using Negocio.Logica;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Datos.Interfaces;
using Datos.Models;

namespace ApiSuvesaPos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class clienteController : Controller
    {
        public NegocioSuvesa.Interfaces.IClienteManagerBL clientesManager;

        public clienteController(NegocioSuvesa.Interfaces.IClienteManagerBL clientesManager)
        {
            this.clientesManager = clientesManager;
        }

        private Negocio.Logica.Clientes db = new Negocio.Logica.Clientes();

        private bool Numerico(string text) // rolando
        {
            double test;
            return double.TryParse(text, out test);
        }

        /// <summary>
        /// Inserta un nuevo cliente
        /// </summary>
        /// <returns>El cliente ingresado</returns>
        /// <response code="200">Cuando le ejecución es exitosa (existan o no resultados)</response>
        /// <response code="401">Cuando no se recibe ApiKey válido en el header del request</response>
        /// <response code="500">Cuando exista un error asociado a la ejecución de la operación</response>
        [HttpPost]
        public async Task<Datos.Helpers.ResponseGeneric<Datos.DTOs.ClienteDTO>> Registrar([FromBody] Datos.DTOs.ClienteDTO cliente)
        {
            try
            {
                return await clientesManager.addClientEntry(cliente);   
            }
            catch (Exception ex)
            {
                return new Datos.Helpers.ResponseGeneric<Datos.DTOs.ClienteDTO>(ex);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public async Task<Datos.Helpers.ResponseGeneric<Datos.DTOs.ClienteDTO>> Actualizar([FromBody] Datos.DTOs.ClienteDTO cliente)
        {

            try
            {
                return await clientesManager.editClient(cliente);
            }
            catch (Exception ex)
            {
                return new Datos.Helpers.ResponseGeneric<Datos.DTOs.ClienteDTO>(ex);
            }

            //try
            //{

            //    string resp = db.Editar(id, cliente);
            //    double test;
            //    if (double.TryParse(resp, out test))// Si el resultado es numerico
            //    {
            //        if (test > 0)//Si el resultado es mayor que cero
            //        {
            //            return Ok("Ok");
            //        }
            //        else
            //        {
            //            throw new Exception(resp);
            //        }
            //    }
            //    else if (resp.Equals("No existe el valor"))
            //    {
            //        return NotFound();
            //    }
            //    else
            //    {
            //        throw new Exception(resp);
            //    }

            //}
            //catch (Exception ex)
            //{
            //    return new BadRequestResult();
            //}
        }


        [HttpPost]
        [Route("/[controller]/[action]")]
        public async Task<Datos.Helpers.ResponseGeneric<Datos.DTOs.ClienteDTO>> ActualizarClienteFacturacion([FromBody] Datos.DTOs.ClienteDTO cliente)
        {

            try
            {
                return await clientesManager.editClientFacturacion(cliente);
            }
            catch (Exception ex)
            {
                return new Datos.Helpers.ResponseGeneric<Datos.DTOs.ClienteDTO>(ex);
            }
        }

        /// <summary>
        /// Obtiene un listado de clientes por cedula
        /// </summary>
        /// <returns>El cliente ingresado</returns>
        /// <response code="200">Cuando le ejecución es exitosa (existan o no resultados)</response>
        /// <response code="401">Cuando no se recibe ApiKey válido en el header del request</response>
        /// <response code="500">Cuando exista un error asociado a la ejecución de la operación</response>
        [HttpPost]
        [Route("/[controller]/[action]")]
        public async Task<Datos.Helpers.ResponseGeneric<IEnumerable<Datos.DTOs.FiltranClienteDTO>>> BuscarCedula([FromBody] Datos.DTOs.BuscarClienteDTO request)
        {
            try
            {   
                return await clientesManager.getClientByCedula(request);
            }
            catch (Exception ex)
            {
                return new Datos.Helpers.ResponseGeneric<IEnumerable<Datos.DTOs.FiltranClienteDTO>>(ex);
            }

            //if (pornombre == false && !this.Numerico(filtro))
            //{
            //    return BadRequest("El parametro filtro no tiene el valor esperado. Se esperaba un valor numerico.");
            //}

            //var result = this.db.Buscar(pornombre, filtro);
            //if (result != null)
            //{
            //    return Ok(result);
            //}
            //else
            //{
            //    return new NoContentResult();
            //}
        }

        /// <summary>
        /// Obtiene un listado de clientes por nombre
        /// </summary>
        /// <returns>El cliente ingresado</returns>
        /// <response code="200">Cuando le ejecución es exitosa (existan o no resultados)</response>
        /// <response code="401">Cuando no se recibe ApiKey válido en el header del request</response>
        /// <response code="500">Cuando exista un error asociado a la ejecución de la operación</response>
        [HttpPost]
        [Route("/[controller]/[action]")]
        public async Task<Datos.Helpers.ResponseGeneric<IEnumerable<Datos.DTOs.FiltranClienteDTO>>> BuscarNombre([FromBody] Datos.DTOs.BuscarClienteDTO request)
        {
            try
            {
                return await clientesManager.getClientByNombre(request);
            }
            catch (Exception ex)
            {
                return new Datos.Helpers.ResponseGeneric<IEnumerable<Datos.DTOs.FiltranClienteDTO>>(ex);
            }
        }

        /// <summary>
        /// Obtiene un listado de clientes por cedula y nombre
        /// </summary>
        /// <returns>El cliente ingresado</returns>
        /// <response code="200">Cuando le ejecución es exitosa (existan o no resultados)</response>
        /// <response code="401">Cuando no se recibe ApiKey válido en el header del request</response>
        /// <response code="500">Cuando exista un error asociado a la ejecución de la operación</response>
        [HttpPost]
        [Route("/[controller]/[action]")]
        public async Task<Datos.Helpers.ResponseGeneric<IEnumerable<Datos.DTOs.FiltranClienteDTO>>> Buscar([FromBody] Datos.DTOs.BuscarClienteDTO request)
        {
            try
            {
                return await clientesManager.getClientByFiltro(request);
            }
            catch (Exception ex)
            {
                return new Datos.Helpers.ResponseGeneric<IEnumerable<Datos.DTOs.FiltranClienteDTO>>(ex);
            }
        }

        /// <response code="500">Cuando exista un error asociado a la ejecución de la operación</response>
        [HttpPost]
        [Route("/[controller]/[action]")]
        public async Task<Datos.Helpers.ResponseGeneric<Datos.Models.CorreosComprobantes>> ObtenerEmailsComprobantes(long id)
        {
            try
            {
                return await clientesManager.getEmailsClient(id);
            }
            catch (Exception ex)
            {
                return new Datos.Helpers.ResponseGeneric<Datos.Models.CorreosComprobantes>(ex);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public async Task<Datos.Helpers.ResponseGeneric<Datos.Models.CorreosComprobantes>> ActualizarEmailsComprobantes([FromBody] CorreosComprobantes request)
        {
            try
            {
                return await clientesManager.putClientEmails(request);
            }
            catch (Exception ex)
            {
                return new Datos.Helpers.ResponseGeneric<Datos.Models.CorreosComprobantes>(ex);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public async Task<Datos.Helpers.ResponseGeneric<Datos.DTOs.FiltranClienteDTO>> Desactivar([FromBody] Datos.DTOs.EliminarClienteDTO request)
        {

            try
            {
                return await clientesManager.disableClient(request);
            }
            catch (Exception ex)
            {
                return new Datos.Helpers.ResponseGeneric<Datos.DTOs.FiltranClienteDTO>(ex);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public async Task<Datos.Helpers.ResponseGeneric<Datos.DTOs.FiltranClienteDTO>> Activar([FromBody] Datos.DTOs.EliminarClienteDTO request)
        {

            try
            {
                return await clientesManager.enableClient(request);
            }
            catch (Exception ex)
            {
                return new Datos.Helpers.ResponseGeneric<Datos.DTOs.FiltranClienteDTO>(ex);
            }

            //try
            //{

            //    string resp = db.Eliminar(id);
            //    double test;
            //    if (double.TryParse(resp, out test))// Si el resultado es numerico
            //    {
            //        if (test > 0)//Si el resultado es mayor que cero
            //        {
            //            return Ok("Ok");
            //        }
            //        else
            //        {
            //            throw new Exception(resp);
            //        }
            //    }
            //    else if (resp.Equals("No existe el valor"))
            //    {
            //        return NotFound();
            //    }
            //    else
            //    {
            //        throw new Exception(resp);
            //    }

            //}
            //catch (Exception ex)
            //{
            //    return new BadRequestResult();
            //}
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public async Task<Datos.Helpers.ResponseGeneric<Datos.DTOs.BuscarClienteFacturacionDTO>> ExisteClienteFacturacion([FromBody] Datos.DTOs.BuscarClienteDTO request)
        {
            try
            {
                return await clientesManager.existClientFacturacion(request);
            }
            catch (Exception ex)
            {
                return new Datos.Helpers.ResponseGeneric<Datos.DTOs.BuscarClienteFacturacionDTO>(ex);
            }
        }

    }
}
