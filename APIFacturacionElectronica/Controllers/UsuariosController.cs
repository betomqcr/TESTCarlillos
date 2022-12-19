using APIFacturacionElectronica.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using DatosFE.Class;

namespace APIFacturacionElectronica.Controllers
{
    [Route("api/usuarios")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly IConfiguration configuration;
        private readonly SignInManager<IdentityUser> signInManager;
       

        public UsuariosController(UserManager<IdentityUser> userManager, IConfiguration configuration,
            SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.configuration = configuration;
            this.signInManager = signInManager;
        }

        [HttpPost("registrar")]//api/usuarios/registrar
        public async Task<ActionResult<RespuestaAutenticacion>> Registrar(CredencialUsuario crendeciales)
        {
            try
            {
                Usuarios usuariosDatos = new Usuarios(userManager);
                var usuario = new IdentityUser {UserName= crendeciales.Email, Email= crendeciales.Email};
                var resultado = await usuariosDatos.crearUsuario(usuario, crendeciales.Password);

                if (resultado.Succeeded)
                {
                    return construirToken(crendeciales);
                }
                else
                {
                    return BadRequest(resultado.Errors);
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        
        [HttpPost("login")]
        public async Task<ActionResult<RespuestaAutenticacion>> Login(CredencialUsuario credencial)
        {
            try
            {
                Usuarios usuariosDatos = new Usuarios(userManager, signInManager);
                var resultado = await usuariosDatos.ConsultarUsuario(credencial.Email, credencial.Password);

                if(resultado.Succeeded)
                {
                    return construirToken(credencial);
                }
                else
                {
                    return BadRequest("Login incorrecto");
                }

            }
            catch(Exception ex)
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

                var experiracion = DateTime.UtcNow.AddMinutes(5);

                var securityToken = new JwtSecurityToken(issuer: null, audience: null, claims: claims,
                    expires: experiracion, signingCredentials: creds);

                return new RespuestaAutenticacion()
                {
                    Token = new JwtSecurityTokenHandler().WriteToken(securityToken),
                    Expiracion = experiracion
                };


            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
