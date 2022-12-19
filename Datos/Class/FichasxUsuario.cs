using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
	public class FichasxUsuario
	{
		private SeePOSContext entities;

		public FichasxUsuario()
		{
			entities = new SeePOSContext();
		}

		public int Crear(Models.FichasxUsuario fichasxusuario) // registro de FichasxUsuario
		{
			try
			{
				entities.FichasxUsuarios.Add(fichasxusuario);
				return entities.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<Models.FichasxUsuario> Buscar(bool porNombre, string filtro)  //consultar FichasxUsuario
		{
			try
			{
				List<Models.FichasxUsuario> result;
				if (porNombre == true)
				{
					var temp = from c in entities.FichasxUsuarios
							   where c.Usuario.Contains(filtro)
							   select c;
					result = temp.ToList<Models.FichasxUsuario>();
				}
				else
				{
					var temp = from c in entities.FichasxUsuarios
							   where c.Id == Convert.ToInt32(filtro)
							   select c;
					result = temp.ToList<Models.FichasxUsuario>();
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

		public int Editar(long id, Models.FichasxUsuario nuevo) //editar FichasxUsuario
		{
			try
			{
				var p = entities.FichasxUsuarios.Find(id);
				Models.FichasxUsuario viejo = p;
				if (viejo != null)
				{
					viejo.Id = nuevo.Id;
					viejo.IdUsuario = nuevo.IdUsuario;
					viejo.Usuario = nuevo.Usuario;
					viejo.Desde = nuevo.Desde;
					viejo.Hasta = nuevo.Hasta;
					viejo.EnMostrador = nuevo.EnMostrador;

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

		public int Borrar(decimal id) //borrar FichasxUsuario
		{
			try
			{
				var p = entities.FichasxUsuarios.Find(id);
				Models.FichasxUsuario Nuevo = p;
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


