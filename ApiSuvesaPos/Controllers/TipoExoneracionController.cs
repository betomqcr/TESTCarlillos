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
    public class TipoExoneracionController : Controller
    {
        public NegocioSuvesa.Interfaces.ITipoExoneracionBL _tipoExoneracionManager;

        public TipoExoneracionController(NegocioSuvesa.Interfaces.ITipoExoneracionBL tipoExoneracionManager)
        {
            this._tipoExoneracionManager = tipoExoneracionManager;
        }

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
        [HttpGet]
        public Datos.Helpers.ResponseGeneric<List<Datos.Models.TipoExoneracion>> ObtenerTipoIdentificacion()
        {
            try
            {
                return _tipoExoneracionManager.getTipoExoneracion();   
            }
            catch (Exception ex)
            {
                return new Datos.Helpers.ResponseGeneric<List<Datos.Models.TipoExoneracion>> (ex);
            }
        }

    }
}
