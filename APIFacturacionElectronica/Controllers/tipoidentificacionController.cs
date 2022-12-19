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
    public class tipoidentificacionController : Controller
    {
        private NegocioFE.Logica.TipoIdentificaciones db = new NegocioFE.Logica.TipoIdentificaciones();


        [HttpGet]        
        public IActionResult GetTipoIdentificacion()
        {

            var result = this.db.Obtener_TiposIdentificaciones();
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
