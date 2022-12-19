using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
	public class NoMAG
	{
		private SeePOSContext entities;

		public NoMAG()
		{
			entities = new SeePOSContext();
		}

		public int Crear(Models.NoMag nomag) // registro de NoMAG
		{
			try
			{
				entities.NoMags.Add(nomag);
				return entities.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<Models.NoMag> Buscar(bool porNombre, string filtro)  //consultar NoMAG
		{
			try
			{
				List<Models.NoMag> result;
				if (porNombre == true)
				{
					//devuelve todos los registros
					var temp = from c in entities.NoMags						   
							   select c;
					result = temp.ToList<Models.NoMag>();
				}
				else
				{
					var temp = from c in entities.NoMags
							   where c.Id == Convert.ToInt32(filtro)
							   select c;
					result = temp.ToList<Models.NoMag>();
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

		public int Editar(long id, Models.NoMag nuevo) //editar NoMAG
		{
			try
			{
				var p = entities.NoMags.Find(id);
				Models.NoMag viejo = p;
				if (viejo != null)
				{
					viejo.Id = nuevo.Id;
					viejo.Identificacion = nuevo.Identificacion;

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

		public int Borrar(decimal id) //borrar NoMAG
		{
			try
			{
				var p = entities.NoMags.Find(id);
				if (p != null)
				{
					entities.Remove(p);
					return entities.SaveChanges();
                }
                else
                {
					return 0;
                }

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}


