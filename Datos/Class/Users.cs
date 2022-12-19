using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.AspNetCore.Identity;

namespace Datos.Class
{
    public class Users
    {
        private SeePOSContext entities;
        private UserManager<IdentityUser> manager;
        private SignInManager<IdentityUser> signInManager;



        public Users(UserManager<IdentityUser> manager)
        {
            entities = new SeePOSContext();
            this.manager = manager;

        }

        public Users(SignInManager<IdentityUser> signInManager)
        {
            this.signInManager = signInManager;
            entities = new SeePOSContext();
        }

        public Users(UserManager<IdentityUser> manager, SignInManager<IdentityUser> signInManager)
        {
            this.signInManager = signInManager;
            this.manager = manager;
            entities = new SeePOSContext();
        }


        public async Task<IdentityResult> crearUsuario(IdentityUser usuario, string pass)
        {
            try
            {
                return await manager.CreateAsync(usuario, pass);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<SignInResult> ConsultarUsuario(string email, string password)
        {
            try
            {
                return await signInManager.PasswordSignInAsync(email, password,
                    isPersistent: false, lockoutOnFailure: false);
                //var usuario = new IdentityUser { UserName = crendeciales.Email, Email = crendeciales.Email, P };
                //return await signInManager.SignInAsync(user, password);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
