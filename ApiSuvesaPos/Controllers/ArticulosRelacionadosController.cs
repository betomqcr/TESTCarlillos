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
    public class articulosRelacionadosController : Controller
    {
        public NegocioSuvesa.Interfaces.IArticulosRelacionadosManagerBL _articulosRelacionadosManagerBL;

        public articulosRelacionadosController(NegocioSuvesa.Interfaces.IArticulosRelacionadosManagerBL articulosRelacionadosManagerBL)
        {
            this._articulosRelacionadosManagerBL = articulosRelacionadosManagerBL;
        }

        private Negocio.Logica.Clientes db = new Negocio.Logica.Clientes();

        //private bool Numerico(string text)
        //{
        //    double test;
        //    return double.TryParse(text, out test);
        //}

        /// <summary>
        /// Inserta un nuevo articulos
        /// </summary>
        /// <returns>El cliente ingresado</returns>
        /// <response code="200">Cuando le ejecución es exitosa (existan o no resultados)</response>
        /// <response code="401">Cuando no se recibe ApiKey válido en el header del request</response>
        /// <response code="500">Cuando exista un error asociado a la ejecución de la operación</response>
        [HttpPost]
        public async Task<Datos.Helpers.ResponseGeneric<IEnumerable<Datos.DTOs.ArticulosRelacionadosDTO>>> Registrar([FromBody] IEnumerable<Datos.DTOs.ArticulosRelacionadosDTO> articulos)
        {
            try
            {
                return await _articulosRelacionadosManagerBL.addArticulosRelacionadosEntry(articulos);   
            }
            catch (Exception ex)
            {
                return new Datos.Helpers.ResponseGeneric<IEnumerable<Datos.DTOs.ArticulosRelacionadosDTO>>(ex);
            }
        }


        [HttpPost]
        [Route("/[controller]/[action]")]
        public async Task<Datos.Helpers.ResponseGeneric<IEnumerable<Datos.DTOs.ArticulosRelacionadosDTO>>> BuscarArticulosRelacionados([FromBody] Datos.DTOs.ArticulosRelacionadosDTO articulos)
        {
            try
            {
                return await _articulosRelacionadosManagerBL.getArticulosRelacionadosByCodigoPrincipal(articulos);
            }
            catch (Exception ex)
            {
                return new Datos.Helpers.ResponseGeneric<IEnumerable<Datos.DTOs.ArticulosRelacionadosDTO>> (ex);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public async Task<Datos.Helpers.ResponseGeneric<Datos.DTOs.ArticulosRelacionadosDTO>> DesactivarArticulosRelacionados([FromBody] Datos.DTOs.ArticulosRelacionadosDTO articulos)
        {
            try
            {
                return await _articulosRelacionadosManagerBL.disableArticulosRelacionados(articulos);
            }
            catch (Exception ex)
            {
                return new Datos.Helpers.ResponseGeneric<Datos.DTOs.ArticulosRelacionadosDTO>(ex);
            }

        }

    }
}
