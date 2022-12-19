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
    public class devolucionventaController : Controller
    {

        private NegocioFE.Logica.Devoluciones_Ventas db = new NegocioFE.Logica.Devoluciones_Ventas();

        [HttpPut]
        public IActionResult PutCambiarEstadoDevolucionVenta(long id, string estado)
        {
            try
            {

                string resp = db.CambiarEstado(id, estado);// te modifique el metodo para que hagarre la info de respuesta
                if (resp.Equals("1"))
                {
                    return Ok(estado);
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
        [Route("clave")]
        public IActionResult GetObtenerClaveDevolucionVenta(long id)
        {

            var result = this.db.ObtenerClave(id);
            if (id == 0)
            {
                return BadRequest();
            }
            else if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return new NoContentResult();
            }
        }

        [HttpGet]
        [Route("consecutivo")]
        public IActionResult GetObtenerConsecutivoDevolucionVenta(long id)
        {

            var result = this.db.ObtenerConsecutivo(id);
            if (id == 0)
            {
                return BadRequest();
            }
            else if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return new NoContentResult();
            }
        }

        [HttpGet]
        [Route("encabezadoxml")]
        public IActionResult GetObtenerEncabezadoXMLDevolucionesVentas(long id)
        {

            var result = this.db.ObtenerEncabezadoXML(id);
            if (id == 0)
            {
                return BadRequest();
            }
            else if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return new NoContentResult();
            }
        }

        [HttpGet]
        [Route("detallexml")]
        public IActionResult GetObtenerDetalleXMLDevolucionesVentas(long id)
        {

            var result = this.db.ObtenerDetalleXML(id);
            if (id == 0)
            {
                return BadRequest();
            }
            else if (result != null)
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
