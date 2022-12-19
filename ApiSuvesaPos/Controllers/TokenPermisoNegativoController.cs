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
    public class TokenPermisoNegativoController : Controller
    {

        private Negocio.Logica.TokenPermisoNegativo db = new Negocio.Logica.TokenPermisoNegativo();

        private bool Numerico(string text)
        {
            double test;
            return double.TryParse(text, out test);
        }


        [HttpPost]
        public IActionResult SolicitarToken(string IdUsuario, decimal Codigo)
        {
            try
            {
                string resp = db.SolicitarToken(IdUsuario, Codigo);

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


        [HttpGet]
        [Route("tokendia")]
        public IActionResult ConsultarTokenDia()
        {
            var result = this.db.ConsultarToken();
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
        [Route("validartoken")]
        public IActionResult ValidarToken(string IdUsuario, decimal Codigo, string Token)
        {
            var result = this.db.ValidarToken(IdUsuario, Codigo, Token);
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
