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
    public class proveedorController : Controller
    {

        private Negocio.Logica.Proveedores db = new Negocio.Logica.Proveedores();

        private bool Numerico(string text)
        {
            double test;
            return double.TryParse(text, out test);
        }

        public NegocioSuvesa.Interfaces.IProveedoresManagerBL _proveedorManager;

        public proveedorController(NegocioSuvesa.Interfaces.IProveedoresManagerBL proveedorManager)
        {
            this._proveedorManager = proveedorManager;
        }


        [HttpPost]
        public IActionResult Registrar(Datos.Models.Proveedore proveedor)
        {
            try
            {
                string resp = db.Crear(proveedor);

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
        [Route("/[controller]/[action]")]
        public async Task<Datos.Helpers.ResponseGeneric<IEnumerable<Datos.DTOs.ProveedoresFilterInventarioDTO>>> ObtenerProveedoresInventario()
        {
            try
            {
                return await _proveedorManager.getProveedoresFilterInventarios();
            }
            catch (Exception ex)
            {
                return new Datos.Helpers.ResponseGeneric<IEnumerable<Datos.DTOs.ProveedoresFilterInventarioDTO>>(ex);
            }
        }

        [HttpPut]
        public IActionResult Actualizar(int id, Datos.Models.Proveedore proveedor)
        {
            try
            {

                string resp = db.Editar(id, proveedor);
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
        public IActionResult Buscar(bool pornombre, string filtro)
        {
            if (pornombre == false && !this.Numerico(filtro))
            {
                return BadRequest("El parametro filtro no tiene el valor esperado. Se esperaba un valor numerico.");
            }

            var result = this.db.Buscar(pornombre, filtro);
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

                string resp = db.Eliminar(id);
                if (resp.Equals("1"))
                {
                    return Ok("Ok");
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
