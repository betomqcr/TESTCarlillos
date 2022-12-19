using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
	public class Bancos
	{
		private SeePOSContext entities;

		public Bancos()
		{
			entities = new SeePOSContext();
		}

		public int Crear(Models.Banco bancos) // registro de Bancos
		{
			try
			{
				entities.Bancos.Add(bancos);
				return entities.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<Models.Banco> Buscar(bool porNombre, string filtro)  //consultar Bancos
		{
			try
			{
				List<Models.Banco> result;
				if (porNombre == true)
				{
					var temp = from c in entities.Bancos
							   where c.Descripcion.Contains(filtro)
							   orderby c.Descripcion
							   select c;					
					result = temp.ToList<Models.Banco>();
				}
				else
				{
					var temp = from c in entities.Bancos
							   where c.CodigoBanco == Convert.ToInt32(filtro)
							   orderby c.Descripcion
							   select c;
					result = temp.ToList<Models.Banco>();
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

		public int Editar(long id, Models.Banco nuevo) //editar Bancos
		{
			try
			{
				var p = entities.Bancos.Find(id);
				Models.Banco viejo = p;
				if (viejo != null)
				{
					viejo.CodigoBanco = nuevo.CodigoBanco;
					viejo.Descripcion = nuevo.Descripcion;

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

		public int Borrar(long id) //borrar Bancos
		{
			try
			{
				var p = entities.Bancos.Find(id);
				Models.Banco Nuevo = p;
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


