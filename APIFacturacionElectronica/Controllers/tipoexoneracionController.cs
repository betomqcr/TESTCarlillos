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
    public class tipoexoneracionController : Controller
    {
        private NegocioFE.Logica.TipoExoneracion db = new NegocioFE.Logica.TipoExoneracion();

        [HttpGet]
        public IActionResult GetProvincia()
        {

            var result = this.db.Obtener_TipoExoneracion();
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
