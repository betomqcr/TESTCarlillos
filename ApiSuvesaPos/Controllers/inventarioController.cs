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
    public class inventarioController : Controller
    {

        public NegocioSuvesa.Interfaces.IInventarioManagerBL inventarioManager;

        public inventarioController(NegocioSuvesa.Interfaces.IInventarioManagerBL inventarioController)
        {
            this.inventarioManager = inventarioController;
        }

        /// <summary>
        /// Inserta un nuevo inventario
        /// </summary>
        /// <returns>El cliente ingresado</returns>
        /// <response code="200">Cuando le ejecución es exitosa (existan o no resultados)</response>
        /// <response code="401">Cuando no se recibe ApiKey válido en el header del request</response>
        /// <response code="500">Cuando exista un error asociado a la ejecución de la operación</response>
        [HttpPost]
        public async Task<Datos.Helpers.ResponseGeneric<Datos.DTOs.InventarioDTO>> Registrar([FromBody] Datos.DTOs.InventarioDTO inventario)
        {
            try
            {
                return await inventarioManager.addInventario(inventario);
            }
            catch (Exception ex)
            {
                return new Datos.Helpers.ResponseGeneric<Datos.DTOs.InventarioDTO>(ex);
            }
        }

        /// <summary>
        /// Edita un inventario
        /// </summary>
        /// <returns>El cliente ingresado</returns>
        /// <response code="200">Cuando le ejecución es exitosa (existan o no resultados)</response>
        /// <response code="401">Cuando no se recibe ApiKey válido en el header del request</response>
        /// <response code="500">Cuando exista un error asociado a la ejecución de la operación</response>
        [HttpPost]
        [Route("/[controller]/[action]")]
        public async Task<Datos.Helpers.ResponseGeneric<Datos.DTOs.InventarioDTO>> Actualizar([FromBody] Datos.DTOs.InventarioDTO inventario)
        {

            try
            {
                return await inventarioManager.editInventario(inventario);
            }
            catch (Exception ex)
            {
                return new Datos.Helpers.ResponseGeneric<Datos.DTOs.InventarioDTO>(ex);
            }

        }

        /// <summary>
        /// Obtiene un listado de inventarios por Codigo Articulo
        /// </summary>
        /// <returns>El cliente ingresado</returns>
        /// <response code="200">Cuando le ejecución es exitosa (existan o no resultados)</response>
        /// <response code="401">Cuando no se recibe ApiKey válido en el header del request</response>
        /// <response code="500">Cuando exista un error asociado a la ejecución de la operación</response>
        [HttpPost]
        [Route("/[controller]/[action]")]
        public async Task<Datos.Helpers.ResponseGeneric<IEnumerable<Datos.DTOs.InventarioDTO>>> BuscarCodigoArticulo([FromBody] Datos.DTOs.BuscarInventarioDTO request)
        {
            try
            {
                return await inventarioManager.getInventarioByCodigo(request);
            }
            catch (Exception ex)
            {
                return new Datos.Helpers.ResponseGeneric<IEnumerable<Datos.DTOs.InventarioDTO>>(ex);
            }
        }

        /// <summary>
        /// Obtiene un listado de inventarios por Descripcion
        /// </summary>
        /// <returns>El cliente ingresado</returns>
        /// <response code="200">Cuando le ejecución es exitosa (existan o no resultados)</response>
        /// <response code="401">Cuando no se recibe ApiKey válido en el header del request</response>
        /// <response code="500">Cuando exista un error asociado a la ejecución de la operación</response>
        [HttpPost]
        [Route("/[controller]/[action]")]
        public async Task<Datos.Helpers.ResponseGeneric<IEnumerable<Datos.DTOs.InventarioDTO>>> BuscarDescripcion([FromBody] Datos.DTOs.BuscarInventarioDTO request)
        {
            try
            {
                return await inventarioManager.getInventarioByDescripcion(request);
            }
            catch (Exception ex)
            {
                return new Datos.Helpers.ResponseGeneric<IEnumerable<Datos.DTOs.InventarioDTO>>(ex);
            }
        }

        /// <summary>
        /// Obtiene un listado de inventarios por Codigo Articulo y Descripcion
        /// </summary>
        /// <returns>El cliente ingresado</returns>
        /// <response code="200">Cuando le ejecución es exitosa (existan o no resultados)</response>
        /// <response code="401">Cuando no se recibe ApiKey válido en el header del request</response>
        /// <response code="500">Cuando exista un error asociado a la ejecución de la operación</response>
        [HttpPost]
        [Route("/[controller]/[action]")]
        public async Task<Datos.Helpers.ResponseGeneric<IEnumerable<Datos.DTOs.FilterInventarioDTO>>> Buscar([FromBody] Datos.DTOs.BuscarInventarioDTO request)
        {
            try
            {
                return await inventarioManager.getInventarioByFilter(request);
            }
            catch (Exception ex)
            {
                return new Datos.Helpers.ResponseGeneric<IEnumerable<Datos.DTOs.FilterInventarioDTO>>(ex);
            }
        }

        /// <summary>
        /// Obtiene un inventario por Codigo Principal
        /// </summary>
        /// <returns>El cliente ingresado</returns>
        /// <response code="200">Cuando le ejecución es exitosa (existan o no resultados)</response>
        /// <response code="401">Cuando no se recibe ApiKey válido en el header del request</response>
        /// <response code="500">Cuando exista un error asociado a la ejecución de la operación</response>
        [HttpPost]
        [Route("/[controller]/[action]")]
        public async Task<Datos.Helpers.ResponseGeneric<Datos.DTOs.InventarioDTO>> ObtenerUnInventario([FromBody] Datos.DTOs.BuscarInventarioDTO request)
        {
            try
            {
                return await inventarioManager.getOneInventarioByCodigo(request);
            }
            catch (Exception ex)
            {
                return new Datos.Helpers.ResponseGeneric<Datos.DTOs.InventarioDTO>(ex);
            }
        }

        /// <summary>
        /// Desactiva un determinado inventario
        /// </summary>
        /// <returns>El cliente ingresado</returns>
        /// <response code="200">Cuando le ejecución es exitosa (existan o no resultados)</response>
        /// <response code="401">Cuando no se recibe ApiKey válido en el header del request</response>
        /// <response code="500">Cuando exista un error asociado a la ejecución de la operación</response>
        [HttpPost]
        [Route("/[controller]/[action]")]
        public async Task<Datos.Helpers.ResponseGeneric<Datos.DTOs.InventarioDTO>> Desactivar([FromBody] Datos.DTOs.EliminarInventarioDTO request)
        {
            try
            {
                return await inventarioManager.disableInventario(request);
            }
            catch (Exception ex)
            {
                return new Datos.Helpers.ResponseGeneric<Datos.DTOs.InventarioDTO>(ex);
            }
        }

        /// <summary>
        /// Activa un determinado inventario
        /// </summary>
        /// <returns>El cliente ingresado</returns>
        /// <response code="200">Cuando le ejecución es exitosa (existan o no resultados)</response>
        /// <response code="401">Cuando no se recibe ApiKey válido en el header del request</response>
        /// <response code="500">Cuando exista un error asociado a la ejecución de la operación</response>
        [HttpPost]
        [Route("/[controller]/[action]")]
        public async Task<Datos.Helpers.ResponseGeneric<Datos.DTOs.InventarioDTO>> Activar([FromBody] Datos.DTOs.EliminarInventarioDTO request)
        {
            try
            {
                return await inventarioManager.enableInventario(request);
            }
            catch (Exception ex)
            {
                return new Datos.Helpers.ResponseGeneric<Datos.DTOs.InventarioDTO>(ex);
            }

            
        }


        // Codigo legacy
        //private Negocio.Logica.Inventario db = new Negocio.Logica.Inventario();

        //private bool Numerico(string text)
        //{
        //    double test;
        //    return double.TryParse(text, out test);
        //}


        //[HttpPost]
        //public IActionResult Registrar(Datos.Models.Inventario inventario)
        //{
        //    try
        //    {
        //        string resp = db.Crear(inventario);

        //        if (resp.Equals("1"))
        //        {
        //            return Ok(inventario);
        //        }
        //        else
        //        {
        //            throw new Exception(resp);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return new BadRequestResult();
        //    }
        //}

        //[HttpPut]
        //public IActionResult Actualizar(int id, Datos.Models.Inventario inventario)
        //{
        //    try
        //    {

        //        string resp = db.Editar(id, inventario);
        //        if (resp.Equals("1"))
        //        {
        //            return Ok(inventario);
        //        }
        //        else if (resp.Equals("No existe el valor"))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw new Exception(resp);
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        return new BadRequestResult();
        //    }
        //}

        //[HttpGet]
        //public IActionResult Buscar(string codigo)
        //{

        //    var result = this.db.ObtenerInventario(codigo);
        //    if (result != null)
        //    {
        //        return Ok(result);
        //    }
        //    else
        //    {
        //        return new NoContentResult();
        //    }
        //}

        //[HttpDelete]
        //public IActionResult Eliminar(int id)
        //{
        //    try
        //    {

        //        string resp = db.Eliminar(id);
        //        if (resp.Equals("1"))
        //        {
        //            return Ok("Ok");
        //        }
        //        else if (resp.Equals("No existe el valor"))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw new Exception(resp);
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        return new BadRequestResult();
        //    }
        //}

    }
}
