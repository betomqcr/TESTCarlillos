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
    public class emisorController : Controller
    {

        private NegocioFE.Logica.Emisor db = new NegocioFE.Logica.Emisor();

        private bool Transformar(ref DatosFE.Models.Emisor n, Models.Emisores v)
        {
            //Transforma de un modelo al otro
            try
            {

                n.TipoIdentificacion = v.TipoIdentificacion;
                n.Identificacion = v.Identificacion;
                n.Nombre = v.Nombre;
                n.Correo = v.Correo;
                n.Telefono = v.Telefono;
                n.Sucursal = v.Sucursal;
                n.Provincia = v.Provincia;
                n.Canton = v.Canton;
                n.Distrito = v.Distrito;
                n.OtrasSeñas = v.OtrasSeñas;
                n.Usuario = v.Usuario;
                n.Clave = v.Clave;
                n.Certificado = v.Certificado;
                n.NumeroResolucion = v.NumeroResolucion;
                n.FechaResolucion = v.FechaResolucion;
                n.IdTipoIdentificacion = v.IdTipoIdentificacion;
                n.Id = v.Id;
                n.VenceCertificado = v.VenceCertificado;

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public IActionResult PostEmisor(Emisores emisor)
        {
            try
            {
                DatosFE.Models.Emisor NuevoEmisor = new DatosFE.Models.Emisor();
                if (this.Transformar(ref NuevoEmisor, emisor) == true)
                {
                    string resp = db.Crear(NuevoEmisor);

                    if (resp.Equals("1"))
                    {
                        return Ok(NuevoEmisor);
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
        public IActionResult PutEmisor(int id, Models.Emisores emisor)
        {
            try
            {
                DatosFE.Models.Emisor NuevoEmisor = new DatosFE.Models.Emisor();
                if (this.Transformar(ref NuevoEmisor, emisor) == true)
                {
                    string resp = db.Modificar(id, NuevoEmisor);// te modifique el metodo para que hagarre la info de respuesta
                    if (resp.Equals("1"))
                    {
                        return Ok(NuevoEmisor);
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
        public IActionResult GetObtenerEmisor(int id)
        {

            var result = this.db.Obtener(id);
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
                return new NotFoundResult();
            }
        }


    }
}
