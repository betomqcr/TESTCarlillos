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

namespace ApiSuvesaPos.Controllers
{
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("[controller]")]
    public class ajustecpagarController : Controller
    {
        private Negocio.Logica.Ajustecpagar db = new Negocio.Logica.Ajustecpagar();

        private bool Numerico(string text)
        {
            double test;
            return double.TryParse(text, out test);
        }

        [HttpPost]
        public IActionResult PostAjustecpagar(Datos.Models.Ajustescpagar nuevo)
        {
            try
            {

                string resp = db.Crear(nuevo);

                double test;
                if (double.TryParse(resp, out test))// Si el resultado es numerico
                {
                    if (test > 0)//Si el resultado es mayor que cero
                    {
                        return Ok("Ok");
                    }
                    else
                    {
                        throw new Exception(resp);
                    }
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

        [HttpPut]
        public IActionResult PutAjustecpagar(long id)
        {

            string resp = this.db.Anular(id);
            double test;
            if (double.TryParse(resp, out test))// Si el resultado es numerico
            {
                if (test > 0)//Si el resultado es mayor que cero
                {
                    return Ok("Ok");
                }
                else
                {
                    throw new Exception(resp);
                }
            }
            else if (resp.Equals("No existe el valor"))
            {
                return NotFound();
            }
            else
            {
                throw new Exception(resp);
            }
        }

        [HttpGet]
        public IActionResult GetAjustecpagar(bool porid, string filtro)
        {
            if (porid == true && !this.Numerico(filtro))
            {
                return BadRequest("El parametro filtro no tiene el valor esperado. Se esperaba un valor numerico.");
            }

            var result = this.db.Buscar(porid,filtro);
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
