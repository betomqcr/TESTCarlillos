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
    public class agenteventaController : Controller
    {

        private Negocio.Logica.Agente_Ventas db = new Negocio.Logica.Agente_Ventas();

        [HttpPost]
        public IActionResult PostAgenteVenta(Datos.Models.AgenteVenta nuevo)
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
        public IActionResult PutAgenteVenta(int id ,Datos.Models.AgenteVenta agenteventa)
        {
            try
            {

                string resp = db.Editar(id, agenteventa);

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

        [HttpGet]
        public IActionResult GetAgenteVenta(string nombre)
        {

            var result = this.db.Buscar(nombre);
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
        public IActionResult DeleteAgenteVenta(int id)
        {

            var resp = this.db.Eliminar(id);
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

    }
}
