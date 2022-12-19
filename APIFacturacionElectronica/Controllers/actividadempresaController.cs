using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using APIFacturacionElectronica.Models;

namespace APIFacturacionElectronica.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class actividadempresaController : Controller
    {

        NegocioFE.Logica.ActividadEmpresa db = new NegocioFE.Logica.ActividadEmpresa();


        [HttpGet]
        public IActionResult GetObtenerActividadesEmpresa(int emisor)
        {

            var result = db.Buscar(emisor); //this._context.Books.Include(c => c.Authors).SingleOrDefault(t => t.Id_Book == id);
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
