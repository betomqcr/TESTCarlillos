using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using APIFacturacionElectronica.Models;
using NegocioFE.Logica;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace APIFacturacionElectronica.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class feController : Controller
    {

        private NegocioFE.EnvioComprobantes FE = new NegocioFE.EnvioComprobantes();

        [HttpPut]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Route("enviar")]        
        public IActionResult PutEnviarComprobanteElectronico(string id, string tipodoc)
        {
            try
            {

                string resp;

                switch (tipodoc.ToUpper())
                {
                    case "FACTURA":
                        resp = this.FE.EnviarFactura(id);
                        break;

                    case "DEVOLUCION":
                        resp = this.FE.EnviarDevolucion(id);
                        break;

                    case "MENSAJE":
                        resp = this.FE.EnviarMensajeReceptor(id);
                        break;

                    default:
                        resp = "No existe el valor";
                        break;
                }

                if (resp.Equals("1"))
                {
                    return Ok("");
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

        [HttpPut]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Route("actualizar")]
        public IActionResult PutActualizarComprobanteElectronico(string id, string tipodoc)
        {
            try
            {

                string resp;

                switch (tipodoc.ToUpper())
                {
                    case "FACTURA":
                        resp =  this.FE.ActualizarEstadoFactura(id);
                        break;

                    case "DEVOLUCION":
                        resp =  this.FE.ActualizarEstadoDevolucion(id);
                        break;

                    case "MENSAJE":
                        resp = ""; // this.FE.EnviarMensajeReceptor(id);
                        break;

                    default:
                        resp = "No existe el valor";
                        break;
                }

                if (resp.Equals("1"))
                {
                    return Ok("");
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

        [HttpPut]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Route("correo")]
        public IActionResult PutCorreoComprobanteElectronico(string id, string tipodoc)
        {
            try
            {

                string resp;

                switch (tipodoc.ToUpper())
                {
                    case "FACTURA":
                        resp = this.FE.EnviarCorreoFactura(id);
                        break;

                    case "DEVOLUCION":
                        resp = ""; // this.FE.EnviarDevolucion(id);
                        break;

                    default:
                        resp = "No existe el valor";
                        break;
                }

                if (resp.Equals("1"))
                {
                    return Ok("");
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
