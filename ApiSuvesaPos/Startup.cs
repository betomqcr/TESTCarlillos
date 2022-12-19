using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace ApiSuvesaPos
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(
                opciones => opciones.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes(Configuration["llavejwt"])),
                    ClockSkew = TimeSpan.Zero
                });
            services.AddDbContext<SeePOSContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("BloggingDatabase"))
                );
            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1", new OpenApiInfo { Title = "APIFacturacionElectronica", Version = "v1" });
            //});

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API SUVESA (SeePOS)", Version = "v1" });
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First()); //This line
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type= ReferenceType.SecurityScheme,
                                Id= "Bearer"
                            }
                        },
                        new string[]{}
                    }
                });
            });

            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<SeePOSContext>().AddDefaultTokenProviders();
            services.AddCors(options =>
            {
                options.AddPolicy("AllowOrigin", opt =>
                    opt.AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                );
            });

            services.AddSingleton<IConfiguration>(Configuration);

            // Interface Datos
            services.AddScoped<Datos.Interfaces.IClientesManagerDA, Datos.Class.ClientesManager>();
            services.AddScoped<Datos.Interfaces.IConnectionManager, Datos.Connection.ConnectionManager>();
            services.AddScoped<Datos.Interfaces.ICartaExoneracionManagerDA, Datos.Class.CartaExoneracionManager>();
            services.AddScoped<Datos.Interfaces.ITipoExoneracionManagerDA, Datos.Class.TipoExoneracionManager>();
            services.AddScoped<Datos.Interfaces.IInventariosManagerDA, Datos.Class.InventariosManagerDA>();
            services.AddScoped<Datos.Interfaces.ISubFamiliasManagerDA, Datos.Class.SubFamiliasManagerDA>();
            services.AddScoped<Datos.Interfaces.ISubUbicacionesManagerDA, Datos.Class.SubUbicacionesManagerDA>();
            services.AddScoped<Datos.Interfaces.IProveedoresManagerDA, Datos.Class.ProveedoresManagerDA>();
            services.AddScoped<Datos.Interfaces.IMarcaManagerDA, Datos.Class.MarcaManagerDA>();
            services.AddScoped<Datos.Interfaces.IPresentacionesManagerDA, Datos.Class.PresentacionesManagerDA>();
            services.AddScoped<Datos.Interfaces.IMonedasManagerDA, Datos.Class.MonedaManagerDA>();
            services.AddScoped<Datos.Interfaces.IImpuestosManagerDA, Datos.Class.ImpuestosManagerDA>();
            services.AddScoped<Datos.Interfaces.IBodegasManagerDA, Datos.Class.BodegasManagerDA>();
            services.AddScoped<Datos.Interfaces.IArticulosRelacionadosManagerDA, Datos.Class.ArticulosRelacionadosManagerDA>();

            // Interface Negocio
            services.AddScoped<NegocioSuvesa.Interfaces.IValidaciones, NegocioSuvesa.Class.Validaciones>();
            services.AddScoped<NegocioSuvesa.Interfaces.IClienteManagerBL, NegocioSuvesa.Class.ClienteManager>();
            services.AddScoped<NegocioSuvesa.Interfaces.ICartaExoneracionManagerBL, NegocioSuvesa.Class.CartaExoneracionManagerBL>();
            services.AddScoped<NegocioSuvesa.Interfaces.ITipoExoneracionBL, NegocioSuvesa.Class.TipoExoneracionManager>();
            services.AddScoped<NegocioSuvesa.Interfaces.IInventarioManagerBL, NegocioSuvesa.Class.InventarioManagerBL>();
            services.AddScoped<NegocioSuvesa.Interfaces.ISubFamiliasManagerBL, NegocioSuvesa.Class.SubFamiliasManagerBL>();
            services.AddScoped<NegocioSuvesa.Interfaces.ISubUbicacionesManagerBL, NegocioSuvesa.Class.SubUbicacionesManagerBL>();
            services.AddScoped<NegocioSuvesa.Interfaces.IProveedoresManagerBL, NegocioSuvesa.Class.ProveedoresManagerBL>();
            services.AddScoped<NegocioSuvesa.Interfaces.IMarcaManagerBL, NegocioSuvesa.Class.MarcasManager>();
            services.AddScoped<NegocioSuvesa.Interfaces.IPresentacionesManagerBL, NegocioSuvesa.Class.PresentacionesManagerBL>();
            services.AddScoped<NegocioSuvesa.Interfaces.IMonedaManagerBL, NegocioSuvesa.Class.MonedasManagerBL>();
            services.AddScoped<NegocioSuvesa.Interfaces.IImpuestoManagerBL, NegocioSuvesa.Class.ImpuestosManagerBL>();
            services.AddScoped<NegocioSuvesa.Interfaces.IBodegasManagerBL, NegocioSuvesa.Class.BodegasManagerBL>();
            services.AddScoped<NegocioSuvesa.Interfaces.IArticulosRelacionadosManagerBL, NegocioSuvesa.Class.ArticulosRelacionadosManagerBL>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("./v1/swagger.json", "SUVESA API V1"); //originally "./swagger/v1/swagger.json"
                });
                //app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "APIFacturacionElectronica v1"));
                //  app.UseSwaggerUI();
            //}

            app.UseRouting();

            app.UseCors("AllowOrigin");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
