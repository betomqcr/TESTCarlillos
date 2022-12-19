using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
	public class Perfil_x_Usuario
	{
		private SeePOSContext entities;

		public Perfil_x_Usuario()
		{
			entities = new SeePOSContext();
		}

		public int Crear(Models.PerfilXUsuario perfil_x_usuario) // registro de Perfil_x_Usuario
		{
			try
			{
				entities.PerfilXUsuarios.Add(perfil_x_usuario);
				return entities.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<Models.PerfilXUsuario> Buscar(bool porNombre, string filtro)  //consultar Perfil_x_Usuario
		{
			try
			{
				List<Models.PerfilXUsuario> result;
				if (porNombre == true)
				{
					var temp = from c in entities.PerfilXUsuarios
							   select c;
					result = temp.ToList<Models.PerfilXUsuario>();
				}
				else
				{
					var temp = from c in entities.PerfilXUsuarios
							   select c;
					result = temp.ToList<Models.PerfilXUsuario>();
				}
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

		public int Editar(long id, Models.PerfilXUsuario nuevo) //editar Perfil_x_Usuario
		{
			try
			{
				var p = entities.PerfilXUsuarios.Find(id);
				Models.PerfilXUsuario viejo = p;
				if (viejo != null)
				{
					viejo.IdPerfil = nuevo.IdPerfil;
					viejo.IdUsuario = nuevo.IdUsuario;
					viejo.IdPerUser = nuevo.IdPerUser;

					entities.Entry(viejo).State = EntityState.Modified;

					return entities.SaveChanges();
				}
				else
				{
					return 0;// no se encotro el registro solicitado.
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public int Borrar(long id) //borrar Perfil_x_Usuario
		{
			try
			{
				var p = entities.PerfilXUsuarios.Find(id);
				Models.PerfilXUsuario Nuevo = p;
				if (Nuevo != null)
				{
					entities.Remove(p);
					return entities.SaveChanges();
				}
				else
				{
					return 0;// no se encotro el registro solicitado.
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}


