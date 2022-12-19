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
    public class preventaController : Controller
    {

        private Negocio.Logica.Preventas db = new Negocio.Logica.Preventas();

        private bool Numerico(string text)
        {
            double test;
            return double.TryParse(text, out test);
        }


        [HttpPost]
        public IActionResult Registrar(Datos.Models.PreVenta preventa)
        {
            try
            {
                string resp = db.Crear(preventa);

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

        [HttpPost]
        [Route("insertar_abonoreintegro")]
        public IActionResult Insertar_AbonoReintegro(Datos.Models.Abonoreintegro Abono)
        {
            try
            {
                string resp = db.InsertarAbonoReintegro(Abono);

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

        [HttpPost]
        [Route("facturar_preventa")]
        public IActionResult Facturar_Preventa(long IdPreventa, string Tipo, string IdUsuario, int IdEmpresa)
        {
            try
            {
                string resp = db.Facturar_Preventa(IdPreventa, Tipo, IdUsuario, IdEmpresa);

                long test;
                if (long.TryParse(resp, out test))// Si el resultado es numerico
                {
                    if (test > 0)//Si el resultado es mayor que cero
                    {
                        return Ok(test);
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

        [HttpPost]
        [Route("generar_recibodinero")]
        public IActionResult Generar_ReciboDinero(long IdPreAbono, string IdUsuario, int IdEmpresa)
        {
            try
            {
                string resp = db.Generar_ReciboDinero(IdPreAbono, IdUsuario, IdEmpresa);

                long test;
                if (long.TryParse(resp, out test))// Si el resultado es numerico
                {
                    if (test > 0)//Si el resultado es mayor que cero
                    {
                        return Ok(test);
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

        [HttpPost]
        [Route("apartar_preventa")]
        public IActionResult Apartar_Preventa(long IdPreventa, string IdUsuario, int IdEmpresa, double MontoInicial)
        {
            try
            {
                string resp = db.Apartar_Preventa(IdPreventa, IdUsuario, IdEmpresa, MontoInicial);

                long test;
                if (long.TryParse(resp, out test))// Si el resultado es numerico
                {
                    if (test > 0)//Si el resultado es mayor que cero
                    {
                        return Ok(test);
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
        public IActionResult Actualizar(int id, Datos.Models.PreVenta preventa)
        {
            try
            {

                string resp = db.Editar(id, preventa);
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
        [Route("activas")]
        public IActionResult FichasActivas()
        {
            var result = this.db.BuscarFichasActivas();
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
        [Route("obtener")]
        public IActionResult Obtener(long id)
        {
            var result = this.db.obtenerPreVentas(id);
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
        public IActionResult Buscar(bool pornombre, string filtro)
        {

            if (pornombre == false && !this.Numerico(filtro))
            {
                return BadRequest("El parametro filtro no tiene el valor esperado. Se esperaba un valor numerico.");
            }

            var result = this.db.BuscarPreVenta(pornombre, filtro);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return new NoContentResult();
            }
        }

        [HttpPut]
        [Route("inactivarficha")]
        public IActionResult Inactivar(long id, string tipo, string puntoventa)
        {
            try
            {

                string resp = db.InactivarFicha(id, tipo, puntoventa);
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
