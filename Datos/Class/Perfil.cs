using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
	public class Perfil
	{
		private SeePOSContext entities;

		public Perfil()
		{
			entities = new SeePOSContext();
		}

		public int Crear(Models.Perfil perfil) // registro de Perfil
		{
			try
			{
				entities.Perfils.Add(perfil);
				return entities.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<Models.Perfil> Buscar(bool porNombre, string filtro)  //consultar Perfil
		{
			try
			{
				List<Models.Perfil> result;
				if (porNombre == true)
				{
					var temp = from c in entities.Perfils
							   where c.NombrePerfil.Contains(filtro)
							   orderby c.NombrePerfil
							   select c;
					result = temp.ToList<Models.Perfil>();
				}
				else
				{
					var temp = from c in entities.Perfils
							   where c.IdPerfil == Convert.ToInt32(filtro)
							   select c;
					result = temp.ToList<Models.Perfil>();
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

		public int Editar(long id, Models.Perfil nuevo) //editar Perfil
		{
			try
			{
				var p = entities.Perfils.Find(id);
				Models.Perfil viejo = p;
				if (viejo != null)
				{
					viejo.IdPerfil = nuevo.IdPerfil;
					viejo.NombrePerfil = nuevo.NombrePerfil;

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

		public int Borrar(long id) //borrar Perfil
		{
			try
			{
				var p = entities.Perfils.Find(id);
				Models.Perfil Nuevo = p;
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


