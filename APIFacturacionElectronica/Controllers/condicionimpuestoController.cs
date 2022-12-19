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
    public class condicionimpuestoController : Controller
    {

        private NegocioFE.Logica.CondicionImpuesto db = new NegocioFE.Logica.CondicionImpuesto();

        [HttpGet]
        public IActionResult GetObterCondicionImpuesto()
        {

            var result = this.db.Buscar();
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
