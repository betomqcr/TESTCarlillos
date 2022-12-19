using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using Negocio.Logica;
using ApiSuvesaPos.Models;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Datos.Class;

namespace ApiSuvesaPos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class usuarioController : Controller
    {

        private Negocio.Logica.Usuarios db = new Negocio.Logica.Usuarios();
        private readonly UserManager<IdentityUser> userManager;
        private readonly IConfiguration configuration;
        private readonly SignInManager<IdentityUser> signInManager;

        public usuarioController(UserManager<IdentityUser> userManager, IConfiguration configuration,
            SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.configuration = configuration;
            this.signInManager = signInManager;
        }

        private bool Numerico(string text)
        {
            double test;
            return double.TryParse(text, out test);
        }


        [HttpPost]
        public async Task<ActionResult<RespuestaAutenticacion>> Registrar(Datos.Models.Usuario usuario)
        {
            try
            {
                Users usu = new Datos.Class.Users(userManager);

                int resp = db.Crear(usuario);

                if (resp == 1)
                {
                    var User = new IdentityUser { UserName = usuario.Email, Email = usuario.Email};
                    var resultado = await usu.crearUsuario(User, usuario.Password);

                    if (resultado.Succeeded )
                    {
                        string res = db.Editar(long.Parse(usuario.IdUsuario), usuario);

                        if(res.Equals("1") )
                        {
                            CredencialUsuario temp = new CredencialUsuario()
                            {
                                Email = usuario.Email,
                                Password = usuario.Password
                            };

                            return construirToken(temp);
                        } else
                        {
                            return BadRequest("Error en el registro de usuario, vaya orine y se acuesta");
                        }
                        
                    }
                    else
                    {
                        return BadRequest(resultado.Errors + "Vaya orine y se acuesta");
                    }
                }
                else
                {
                    return BadRequest("Error en el registro de usuario, vaya orine y se acuesta");
                }

                //double test;
                //if (double.TryParse(resp, out test))// Si el resultado es numerico
                //{
                //    if (test > 0)//Si el resultado es mayor que cero
                //    {
                //        return Ok("Ok");
                //    }
                //    else
                //    {
                //        throw new Exception(resp);
                //    }
                //}
                //else
                //{
                //    throw new Exception(resp);
                //}
            }
            catch (Exception ex)
            {
                return new BadRequestResult();
            }
        }

        [HttpPut]
        public IActionResult Actualizar(int id, Datos.Models.Usuario usuario)
        {
            try
            {

                string resp = db.Editar(id, usuario);
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

        [HttpPost("login")]
        public async Task<ActionResult<RespuestaAutenticacion>> Login(CredencialUsuario credencial)
        {
            try
            {
                Users usuariosDatos = new Users(userManager, signInManager);
                var resultado = await usuariosDatos.ConsultarUsuario(credencial.Email, credencial.Password);

                if (resultado.Succeeded)
                {
                    return construirToken(credencial);
                }
                else
                {
                    return BadRequest("Login incorrecto");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private RespuestaAutenticacion construirToken(CredencialUsuario credencialesUsuario)
        {
            try
            {
                var claims = new List<Claim>()
                {
                    new Claim("email", credencialesUsuario.Email)

                };

                var llave = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["llavejwt"]));
                var creds = new SigningCredentials(llave, SecurityAlgorithms.HmacSha256);

                var experiracion = DateTime.UtcNow.AddHours(5);

                var securityToken = new JwtSecurityToken(issuer: null, audience: null, claims: claims,
                    expires: experiracion, signingCredentials: creds);

                return new RespuestaAutenticacion()
                {
                    Token = new JwtSecurityTokenHandler().WriteToken(securityToken),
                    Expiracion = experiracion,
                    Usuario = credencialesUsuario.Email
                };


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
