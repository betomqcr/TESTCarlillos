using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
	public class Rifa
	{
		private SeePOSContext entities;

		public Rifa()
		{
			entities = new SeePOSContext();
		}

		public int Crear(Models.Rifa rifa) // registro de Rifa
		{
			try
			{
				entities.Rifas.Add(rifa);
				return entities.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<Models.Rifa> Buscar(bool porNombre, string filtro)  //consultar Rifa
		{
			try
			{
				List<Models.Rifa> result;
				if (porNombre == true)
				{
					var temp = from c in entities.Rifas
							   where c.Descripcion.Contains(filtro)
							   select c;
					result = temp.ToList<Models.Rifa>();
				}
				else
				{
					var temp = from c in entities.Rifas
							   where c.Id == Convert.ToInt32(filtro)
							   select c;
					result = temp.ToList<Models.Rifa>();
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

		public int Editar(long id, Models.Rifa nuevo) //editar Rifa
		{
			try
			{
				var p = entities.Rifas.Find(id);
				Models.Rifa viejo = p;
				if (viejo != null)
				{
					viejo.Id = nuevo.Id;
					viejo.Descripcion = nuevo.Descripcion;
					viejo.FechaInicio = nuevo.FechaInicio;
					viejo.FechaFin = nuevo.FechaFin;
					viejo.CantMin = nuevo.CantMin;
					viejo.Finalizada = nuevo.Finalizada;
					viejo.Anulada = nuevo.Anulada;

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

		public int Borrar(long id) //borrar Rifa
		{
			try
			{
				var p = entities.Rifas.Find(id);
				Models.Rifa Nuevo = p;
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


