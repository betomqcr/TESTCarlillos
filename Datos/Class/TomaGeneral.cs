using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
	public class TomaGeneral
	{
		private SeePOSContext entities;

		public TomaGeneral()
		{
			entities = new SeePOSContext();
		}

		public int Crear(Models.TomaGeneral tomageneral) // registro de TomaGeneral
		{
			try
			{
				entities.TomaGenerals.Add(tomageneral);
				return entities.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<Models.TomaGeneralDetalle> BuscarDetalle(decimal Id)  //consultar TomaGeneral
		{
			try
			{
				List<Models.TomaGeneralDetalle> result;
					var temp = from c in entities.TomaGeneralDetalles
							   where c.IdToma == Id
							   select c;
					result = temp.ToList<Models.TomaGeneralDetalle>();
				
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

		public List<Models.TomaGeneral> Buscar(bool porNombre, string filtro)  //consultar TomaGeneral
		{
			try
			{
				List<Models.TomaGeneral> result;
				if (porNombre == true)
				{
					var temp = from c in entities.TomaGenerals
							   select c;
					result = temp.ToList<Models.TomaGeneral>();
				}
				else
				{
					var temp = from c in entities.TomaGenerals
							   select c;
					result = temp.ToList<Models.TomaGeneral>();
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

		public int Editar(decimal id, Models.TomaGeneral nuevo) //editar TomaGeneral
		{
			try
			{
				var p = entities.TomaGenerals.Find(id);
				Models.TomaGeneral viejo = p;
				if (viejo != null)
				{
					viejo.IdToma = nuevo.IdToma;
					viejo.Fecha = nuevo.Fecha;
					viejo.Anulado = nuevo.Anulado;
					viejo.Ajustado = nuevo.Ajustado;
					viejo.NumeroAjuste = nuevo.NumeroAjuste;

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

		public int Borrar(decimal id) //borrar TomaGeneral
		{
			try
			{
				var p = entities.TomaGenerals.Find(id);
				entities.Remove(p);
				return entities.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}


