using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
	public class Modulos
	{
		private SeePOSContext entities;

		public Modulos()
		{
			entities = new SeePOSContext();
		}

		public int Crear(Models.Modulo modulos) // registro de Modulos
		{
			try
			{
				entities.Modulos.Add(modulos);
				return entities.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<Models.Modulo> Buscar(bool porNombre, string filtro)  //consultar Modulos
		{
			try
			{
				List<Models.Modulo> result;
				if (porNombre == true)
				{
					var temp = from c in entities.Modulos
							   where c.ModuloNombre.Contains(filtro)
							   select c;
					result = temp.ToList<Models.Modulo>();
				}
				else
				{
					var temp = from c in entities.Modulos
							   where c.IdModulo == Convert.ToInt32(filtro)
							   select c;
					result = temp.ToList<Models.Modulo>();
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

		public int Editar(long id, Models.Modulo nuevo) //editar Modulos
		{
			try
			{
				var p = entities.Modulos.Find(id);
				Models.Modulo viejo = p;
				if (viejo != null)
				{
					viejo.IdModulo = nuevo.IdModulo;
					viejo.ModuloNombreInterno = nuevo.ModuloNombreInterno;
					viejo.ModuloNombre = nuevo.ModuloNombre;
					viejo.Software = nuevo.Software;
					viejo.Grupo = nuevo.Grupo;

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

		public int Borrar(long id) //borrar Modulos
		{
			try
			{
				var p = entities.Modulos.Find(id);
				Models.Modulo Nuevo = p;
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


