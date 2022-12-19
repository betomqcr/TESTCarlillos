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
    public class subFamiliasController : Controller
    {
        public NegocioSuvesa.Interfaces.ISubFamiliasManagerBL _subFamiliasManager;

        public subFamiliasController(NegocioSuvesa.Interfaces.ISubFamiliasManagerBL subFamiliasManager)
        {
            this._subFamiliasManager = subFamiliasManager;
        }

        /// <summary>
        /// Inserta un nuevo cliente
        /// </summary>
        /// <returns>El cliente ingresado</returns>
        /// <response code="200">Cuando le ejecución es exitosa (existan o no resultados)</response>
        /// <response code="401">Cuando no se recibe ApiKey válido en el header del request</response>
        /// <response code="500">Cuando exista un error asociado a la ejecución de la operación</response>
        //[HttpPost]
        //public async Task<Datos.Helpers.ResponseGeneric<Datos.DTOs.CartaExoneracionDTO>> Registrar([FromBody] Datos.DTOs.CartaExoneracionDTO carta)
        //{
        //    try
        //    {
        //        return await _cartaExoneracionManager.addCartaExoneracionEntry(carta);   
        //    }
        //    catch (Exception ex)
        //    {
        //        return new Datos.Helpers.ResponseGeneric<Datos.DTOs.CartaExoneracionDTO>(ex);
        //    }
        //}

        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public async Task<Datos.Helpers.ResponseGeneric<Datos.DTOs.CartaExoneracionDTO>> Actualizar([FromBody] Datos.DTOs.CartaExoneracionDTO carta)
        //{
        //    try
        //    {
        //        return await _cartaExoneracionManager.editCartaExoneracionEntry(carta);
        //    }
        //    catch (Exception ex)
        //    {
        //        return new Datos.Helpers.ResponseGeneric<Datos.DTOs.CartaExoneracionDTO>(ex);
        //    }
        //}

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
        public async Task<Datos.Helpers.ResponseGeneric<IEnumerable<Datos.DTOs.SubFamiliasFilterInventarioDTO>>> ObtenerSubFamiliasInventario()
        {
            try
            {
                return await _subFamiliasManager.getSubFamiliasFilterInventarios();
            }
            catch (Exception ex)
            {
                return new Datos.Helpers.ResponseGeneric<IEnumerable<Datos.DTOs.SubFamiliasFilterInventarioDTO>>(ex);
            }
        }

        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public async Task<Datos.Helpers.ResponseGeneric<Datos.DTOs.CartaExoneracionDTO>> DesactivarCarta([FromBody] Datos.DTOs.BuscarCartaExoneracionDTO carta)
        //{
        //    try
        //    {
        //        return await _cartaExoneracionManager.disableCartaExoneracion(carta);
        //    }
        //    catch (Exception ex)
        //    {
        //        return new Datos.Helpers.ResponseGeneric<Datos.DTOs.CartaExoneracionDTO>(ex);
        //    }

        //}

        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public async Task<Datos.Helpers.ResponseGeneric<Datos.DTOs.CartaExoneracionDTO>> ActivarCarta([FromBody] Datos.DTOs.BuscarCartaExoneracionDTO carta)
        //{
        //    try
        //    {
        //        return await _cartaExoneracionManager.enableCartaExoneracion(carta);
        //    }
        //    catch (Exception ex)
        //    {
        //        return new Datos.Helpers.ResponseGeneric<Datos.DTOs.CartaExoneracionDTO>(ex);
        //    }

        //}

    }
}
