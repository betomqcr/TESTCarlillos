using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
	public class MovimientosBodega
	{
		private SeePOSContext entities;

		public MovimientosBodega()
		{
			entities = new SeePOSContext();
		}

		public int Crear(Models.MovimientosBodega movimientosbodega) // registro de MovimientosBodega
		{
			try
			{
				entities.MovimientosBodegas.Add(movimientosbodega);
				return entities.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<Models.MovimientosBodegaDetalle> BuscarDetalle(long Id)  //consultar MovimientosBodega
		{
			try
			{
				List<Models.MovimientosBodegaDetalle> result;
					var temp = from c in entities.MovimientosBodegaDetalles
							   where c.BoletaMovimiento == Id
							   select c;
					result = temp.ToList<Models.MovimientosBodegaDetalle>();
				
				if (result.Count > 0)
				{
					return result;
				}
				else
				{
					return result;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<Models.MovimientosBodega> Buscar(bool porNombre, string filtro)  //consultar MovimientosBodega
		{
			try
			{
				List<Models.MovimientosBodega> result;
				if (porNombre == true)
				{
					var temp = from c in entities.MovimientosBodegas
							   join b in entities.Bodegas on c.Bodega equals b.IdBodega
							   where c.Cliente.Contains(filtro) || b.NombreBodega.Contains(filtro) || c.Referencia.Contains(filtro)
							   orderby c.Fecha descending
							   select c;
					result = temp.ToList<Models.MovimientosBodega>();
				}
				else
				{
					var temp = from c in entities.MovimientosBodegas
							   where c.BoletaMovimiento == Convert.ToInt32(filtro)
							   select c;
					result = temp.ToList<Models.MovimientosBodega>();
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

		public int Editar(long id, Models.MovimientosBodega nuevo) //editar MovimientosBodega
		{
			try
			{
				var p = entities.MovimientosBodegas.Find(id);
				Models.MovimientosBodega viejo = p;
				if (viejo != null)
				{
					viejo.BoletaMovimiento = nuevo.BoletaMovimiento;
					viejo.Bodega = nuevo.Bodega;
					viejo.Fecha = nuevo.Fecha;
					viejo.FechaEntrada = nuevo.FechaEntrada;
					viejo.Referencia = nuevo.Referencia;
					viejo.Usuario = nuevo.Usuario;
					viejo.Anulado = nuevo.Anulado;
					viejo.Cliente = nuevo.Cliente;

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

		public int Anular(long id) //editar MovimientosBodega
		{
			try
			{
				var p = entities.MovimientosBodegas.Find(id);
				Models.MovimientosBodega viejo = p;
				if (viejo != null)
				{

					viejo.Anulado = true;				
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


		public int Borrar(long id) //borrar MovimientosBodega
		{
			try
			{
				var p = entities.MovimientosBodegas.Find(id);
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


