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
    public class cambioinventarioController : Controller
    {


        private Negocio.Logica.CambioInventario db = new Negocio.Logica.CambioInventario();


        [HttpPost]
        public IActionResult Registrar(Datos.Models.CambioInventario cambio)
        {
            try
            {
                string resp = db.Crear(cambio);

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
        public IActionResult Buscar()
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

        [HttpDelete]
        public IActionResult Eliminar(int id)
        {
            try
            {

                string resp = db.BorrarCambioInventario(id);
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
            catch (Exception ex)
            {
                return new BadRequestResult();
            }
        }

    }
}
