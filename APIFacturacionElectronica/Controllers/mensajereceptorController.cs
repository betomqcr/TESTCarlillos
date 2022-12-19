using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using APIFacturacionElectronica.Models;
using NegocioFE.Logica;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace APIFacturacionElectronica.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class mensajereceptorController : Controller
    {

        private NegocioFE.Logica.MensajeReceptor db = new NegocioFE.Logica.MensajeReceptor();

        [HttpPost]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public IActionResult PostCrearMensajeReceptor(List<DatosFE.Models.MensajeReceptor> Estado)
        {
            try
            {

                string resp = db.Crear(Estado);
                if (resp.Equals("1"))
                {
                    return Ok("OK");
                }
                else
                {
                    throw new Exception(resp);
                }

            }
            catch (Exception ex)
            {
                return new BadRequestResult();
            }
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public IActionResult GetObtenerMensejeReceptor(bool porfecha, DateTime desde, DateTime hasta, bool porestado, string estado)
        {

            var result = this.db.Buscar( porfecha, porestado, estado, desde, hasta);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return new NoContentResult();
            }
        }
    }
}
