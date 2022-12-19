using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
	public class Perfil_x_Modulo
	{
		private SeePOSContext entities;

		public Perfil_x_Modulo()
		{
			entities = new SeePOSContext();
		}

		public int Crear(Models.PerfilXModulo perfil_x_modulo) // registro de Perfil_x_Modulo
		{
			try
			{
				entities.PerfilXModulos.Add(perfil_x_modulo);
				return entities.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<Models.PerfilXModulo> Buscar(bool porNombre, string filtro)  //consultar Perfil_x_Modulo
		{
			try
			{
				List<Models.PerfilXModulo> result;
				if (porNombre == true)
				{
					var temp = from c in entities.PerfilXModulos
							   select c;
					result = temp.ToList<Models.PerfilXModulo>();
				}
				else
				{
					var temp = from c in entities.PerfilXModulos
							   select c;
					result = temp.ToList<Models.PerfilXModulo>();
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

		public int Editar(long id, Models.PerfilXModulo nuevo) //editar Perfil_x_Modulo
		{
			try
			{
				var p = entities.PerfilXModulos.Find(id);
				Models.PerfilXModulo viejo = p;
				if (viejo != null)
				{
					viejo.IdModuloPerfil = nuevo.IdModuloPerfil;
					viejo.IdPerfil = nuevo.IdPerfil;
					viejo.IdModulo = nuevo.IdModulo;
					viejo.AccionEjecucion = nuevo.AccionEjecucion;
					viejo.AccionActualizacion = nuevo.AccionActualizacion;
					viejo.AccionEliminacion = nuevo.AccionEliminacion;
					viejo.AccionBusqueda = nuevo.AccionBusqueda;
					viejo.AccionImpresion = nuevo.AccionImpresion;
					viejo.AccionOpcion = nuevo.AccionOpcion;
					viejo.Menu = nuevo.Menu;

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

		public int Borrar(long id) //borrar Perfil_x_Modulo
		{
			try
			{
				var p = entities.PerfilXModulos.Find(id);
				Models.PerfilXModulo Nuevo = p;
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


