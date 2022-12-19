using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using APIFacturacionElectronica.Models;
using NegocioFE.Logica;

namespace APIFacturacionElectronica.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ubicacionController: Controller
    {
        private NegocioFE.Logica.Ubicacion db = new NegocioFE.Logica.Ubicacion();


        [HttpGet]
        [Route("provincia")]
        public IActionResult GetProvincia()
        {

            var result = this.db.Obtener_Provincia();
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return new NoContentResult();
            }
        }

        [HttpGet]
        [Route("canton")]
        public IActionResult GetCanton(int provincia)
        {

            var result = this.db.Obtener_Canton(provincia);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return new NoContentResult();
            }
        }

        [HttpGet]
        [Route("distrito")]
        public IActionResult GetDistrito(int provincia, int canton)
        {

            var result = this.db.Obtener_Distrito(provincia,canton);
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
