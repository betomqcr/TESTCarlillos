using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
	public class PreTomaGeneral
	{
		private SeePOSContext entities;

		public PreTomaGeneral()
		{
			entities = new SeePOSContext();
		}

		public int Crear(Models.PreTomaGeneral pretomageneral) // registro de PreTomaGeneral
		{
			try
			{
				entities.PreTomaGenerals.Add(pretomageneral);
				return entities.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<Models.PreTomaGeneral> Buscar(bool porNombre, string filtro)  //consultar PreTomaGeneral
		{
			try
			{
				List<Models.PreTomaGeneral> result;
				if (porNombre == true)
				{
					var temp = from c in entities.PreTomaGenerals
							   select c;
					result = temp.ToList<Models.PreTomaGeneral>();
				}
				else
				{
					var temp = from c in entities.PreTomaGenerals
							   select c;
					result = temp.ToList<Models.PreTomaGeneral>();
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

		public List<Models.PreTomaGeneralDetalle> BuscarDetalle(long Id)  //consultar PreTomaGeneral
		{
			try
			{
				List<Models.PreTomaGeneralDetalle> result;
					var temp = from c in entities.PreTomaGeneralDetalles
							   select c;
					result = temp.ToList<Models.PreTomaGeneralDetalle>();
				
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

		public int Editar(decimal id, Models.PreTomaGeneral nuevo) //editar PreTomaGeneral
		{
			try
			{
				var p = entities.PreTomaGenerals.Find(id);
				Models.PreTomaGeneral viejo = p;
				if (viejo != null)
				{
					viejo.IdPreToma = nuevo.IdPreToma;
					viejo.Fecha = nuevo.Fecha;
					viejo.Anulado = nuevo.Anulado;
					viejo.Aplicado = nuevo.Aplicado;
					viejo.Encargado = nuevo.Encargado;

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

		public int Borrar(decimal id) //borrar PreTomaGeneral
		{
			try
			{
				var p = entities.PreTomaGenerals.Find(id);
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


