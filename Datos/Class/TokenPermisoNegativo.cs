using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
	public class TokenPermisoNegativo
	{
		private SeePOSContext entities;

		public TokenPermisoNegativo()
		{
			entities = new SeePOSContext();
		}

		public int SolicitarTokenVentaNegativa(string IdUsuario, decimal Codigo) // registro de TemperaturaCamara
		{
			try
			{
				Random rand = new Random();
				var Token = new Datos.Models.TokenPermisoNegativo();
				Token.IdUsuarioSolicita = IdUsuario;
				Token.Codigo = Codigo;
				Token.Fecha = DateTime.Now;
				Token.Token = rand.Next(0, 999).ToString();

				entities.TokenPermisoNegativos.Add(Token);
				return entities.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<ViewTokenSolicitado> ConsultarToken(string IdUsuario, decimal Codigo, string Token)
		{
			try
			{
				List<ViewTokenSolicitado> result;
				var temp = from c in entities.ViewTokenSolicitados
						   where c.IdUsuarioSolicita == IdUsuario && c.Codigo == Codigo && c.Token == Token
						   select c;
				result = temp.ToList<ViewTokenSolicitado>();

				if (result.Count > 0)
				{
					return result;
				}
				else
				{
					return result = null;
				}

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<ViewTokenSolicitado> ListaTokenSolicitadosdelDia()
		{
			try
			{			
				List<ViewTokenSolicitado> result;
				var temp = from c in entities.ViewTokenSolicitados
						   where c.Fecha.Day == DateTime.Now.Day && c.Fecha.Month == DateTime.Now.Month && c.Fecha.Year == DateTime.Now.Year
						   select c;
				result = temp.ToList<ViewTokenSolicitado>();

				if (result.Count > 0)
				{
					return result;
				}
				else
				{
					return result = null;
				}

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}


	}
}


