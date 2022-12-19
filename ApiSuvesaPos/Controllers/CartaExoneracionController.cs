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

namespace ApiSuvesaPos.Controllers
{
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("[controller]")]
    public class cartaExoneracionController : Controller
    {
        public NegocioSuvesa.Interfaces.ICartaExoneracionManagerBL _cartaExoneracionManager;

        public cartaExoneracionController(NegocioSuvesa.Interfaces.ICartaExoneracionManagerBL cartaExoneracionManager)
        {
            this._cartaExoneracionManager = cartaExoneracionManager;
        }

        private Negocio.Logica.Clientes db = new Negocio.Logica.Clientes();

        //private bool Numerico(string text)
        //{
        //    double test;
        //    return double.TryParse(text, out test);
        //}

        /// <summary>
        /// Inserta un nuevo cliente
        /// </summary>
        /// <returns>El cliente ingresado</returns>
        /// <response code="200">Cuando le ejecución es exitosa (existan o no resultados)</response>
        /// <response code="401">Cuando no se recibe ApiKey válido en el header del request</response>
        /// <response code="500">Cuando exista un error asociado a la ejecución de la operación</response>
        [HttpPost]
        public async Task<Datos.Helpers.ResponseGeneric<Datos.DTOs.CartaExoneracionDTO>> Registrar([FromBody] Datos.DTOs.CartaExoneracionDTO carta)
        {
            try
            {
                return await _cartaExoneracionManager.addCartaExoneracionEntry(carta);   
            }
            catch (Exception ex)
            {
                return new Datos.Helpers.ResponseGeneric<Datos.DTOs.CartaExoneracionDTO>(ex);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public async Task<Datos.Helpers.ResponseGeneric<Datos.DTOs.CartaExoneracionDTO>> Actualizar([FromBody] Datos.DTOs.CartaExoneracionDTO carta)
        {
            try
            {
                return await _cartaExoneracionManager.editCartaExoneracionEntry(carta);
            }
            catch (Exception ex)
            {
                return new Datos.Helpers.ResponseGeneric<Datos.DTOs.CartaExoneracionDTO>(ex);
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

        //[HttpGet]
        //public IActionResult Buscar(bool pornombre, string filtro)
        //{

        //    if (pornombre == false && !this.Numerico(filtro))
        //    {
        //        return BadRequest("El parametro filtro no tiene el valor esperado. Se esperaba un valor numerico.");
        //    }

        //    var result = this.db.Buscar(pornombre, filtro);
        //    if (result != null)
        //    {
        //        return Ok(result);
        //    }
        //    else
        //    {
        //        return new NoContentResult();
        //    }
        //}

        [HttpPost]
        [Route("/[controller]/[action]")]
        public async Task<Datos.Helpers.ResponseGeneric<Datos.DTOs.CartaExoneracionDTO>> BuscarCarta([FromBody] Datos.DTOs.BuscarCartaExoneracionDTO carta)
        {
            try
            {
                return await _cartaExoneracionManager.getCartaExoneracionByCedula(carta);
            }
            catch (Exception ex)
            {
                return new Datos.Helpers.ResponseGeneric<Datos.DTOs.CartaExoneracionDTO>(ex);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public async Task<Datos.Helpers.ResponseGeneric<Datos.DTOs.CartaExoneracionDTO>> DesactivarCarta([FromBody] Datos.DTOs.BuscarCartaExoneracionDTO carta)
        {
            try
            {
                return await _cartaExoneracionManager.disableCartaExoneracion(carta);
            }
            catch (Exception ex)
            {
                return new Datos.Helpers.ResponseGeneric<Datos.DTOs.CartaExoneracionDTO>(ex);
            }

        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public async Task<Datos.Helpers.ResponseGeneric<Datos.DTOs.CartaExoneracionDTO>> ActivarCarta([FromBody] Datos.DTOs.BuscarCartaExoneracionDTO carta)
        {
            try
            {
                return await _cartaExoneracionManager.enableCartaExoneracion(carta);
            }
            catch (Exception ex)
            {
                return new Datos.Helpers.ResponseGeneric<Datos.DTOs.CartaExoneracionDTO>(ex);
            }

        }

    }
}
