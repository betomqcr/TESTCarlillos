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
    public class cartaexoneracionController : Controller
    {
        
        private NegocioFE.Logica.CartaExoneracion  db = new NegocioFE.Logica.CartaExoneracion();

        private bool Transformar(ref DatosFE.Models.CartaExoneracion NuevaCarta, Models.CartaExoneracion carta)
        {
            //Transforma de un modelo al otro
            try
            {
                int Min = 0;//valor min de tabla impuesto
                int Max = 13;//valor max de tabla impuesto
                if (carta.Impuesto >= Min || carta.Impuesto <= Max)
                {
                    NuevaCarta.Identificacion = carta.Identificacion;
                    NuevaCarta.IdTipoExoneracion = carta.IdTipoExoneracion;
                    NuevaCarta.NumeroDocumento = carta.NumeroDocumento;
                    NuevaCarta.FechaEmision = carta.FechaEmision;
                    NuevaCarta.FechaVence = carta.FechaVence;
                    NuevaCarta.PorcentajeCompra = carta.PorcentajeCompra;
                    NuevaCarta.Impuesto = carta.Impuesto;
                    NuevaCarta.Nota = carta.Nota;
                    return true;
                }
                else
                {
                    return false;//monto del impuesto invalido
                }                
            }
            catch (Exception ex)
            {
                return false;
            }            
        }

        [HttpPost]
        public IActionResult PostCartaExoneracion(Models.CartaExoneracion carta)
        {
            try
            {
                DatosFE.Models.CartaExoneracion NuevaCarta = new DatosFE.Models.CartaExoneracion();
                if (this.Transformar(ref NuevaCarta, carta) == true)
                {
                    string resp = db.Crear(NuevaCarta);

                    if (resp.Equals("1"))
                    {
                        return Ok(NuevaCarta);
                    }
                    else
                    {
                        throw new Exception(resp);
                    }
                }
                else
                {
                    throw new Exception("Formato de la carta es invalido");
                }
                   

            }
            catch (Exception ex)
            {
                return new BadRequestResult();
            }
        }

        [HttpPut]
        public IActionResult PutCartaExoneracion(int id, Models.CartaExoneracion carta)
        {
            try
            {
                DatosFE.Models.CartaExoneracion NuevaCarta = new DatosFE.Models.CartaExoneracion();
               if (this.Transformar(ref NuevaCarta, carta) == true)
                {
                    string resp = db.Editar(id,NuevaCarta);// te modifique el metodo para que hagarre la info de respuesta
                    if (resp.Equals("1"))
                    {
                        return Ok(NuevaCarta);
                    }
                    else if (resp.Equals("No existe el valor"))//hay que modificar datosfe para que devuleva el texto.
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw new Exception(resp);
                    }
                }
                else
                {
                    throw new Exception("Formato de la carta es invalido");
                }                              

            }
            catch (Exception ex)
            {
                return new BadRequestResult();
            }
        }

        [HttpGet]
         public IActionResult GetObtenerCartaExoneracion(long Identificacion)
        {

            var result = this.db.ObtenerCartaExoneracion(Identificacion);
            if (Identificacion == 0)
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
