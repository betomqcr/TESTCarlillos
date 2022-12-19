using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
	public class PedidoBodega
	{
		private SeePOSContext entities;

		public PedidoBodega()
		{
			entities = new SeePOSContext();
		}

		public int Crear(Models.PedidoBodega pedidobodega) // registro de PedidoBodega
		{
			try
			{
				entities.PedidoBodegas.Add(pedidobodega);
				return entities.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<Models.PedidoBodega> Buscar(bool porNombre, string filtro)  //consultar PedidoBodega
		{
			try
			{
				List<Models.PedidoBodega> result;
				if (porNombre == true)
				{
					var temp = from c in entities.PedidoBodegas
							   select c;
					result = temp.ToList<Models.PedidoBodega>();
				}
				else
				{
					var temp = from c in entities.PedidoBodegas
							   select c;
					result = temp.ToList<Models.PedidoBodega>();
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

		public int Editar(long id, Models.PedidoBodega nuevo) //editar PedidoBodega
		{
			try
			{
				var p = entities.PedidoBodegas.Find(id);
				Models.PedidoBodega viejo = p;
				if (viejo != null)
				{
					viejo.IdPedido = nuevo.IdPedido;
					viejo.Consecutivo = nuevo.Consecutivo;
					viejo.FechaSolicitud = nuevo.FechaSolicitud;
					viejo.FechaPedido = nuevo.FechaPedido;
					viejo.IdUsuarioSolicitud = nuevo.IdUsuarioSolicitud;
					viejo.Codigo = nuevo.Codigo;
					viejo.CantidadSolicitud = nuevo.CantidadSolicitud;
					viejo.CantidadPedido = nuevo.CantidadPedido;
					viejo.Proveedor = nuevo.Proveedor;
					viejo.Estado = nuevo.Estado;
					viejo.Observaciones = nuevo.Observaciones;
					viejo.PrecioUnid = nuevo.PrecioUnid;
					viejo.CantidadPuntos = nuevo.CantidadPuntos;
					viejo.IdUsuarioPidio = nuevo.IdUsuarioPidio;
					viejo.IdUsuarioRecibio = nuevo.IdUsuarioRecibio;
					viejo.FechaRecibido = nuevo.FechaRecibido;

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

		public int Borrar(long id) //borrar PedidoBodega
		{
			try
			{
				var p = entities.PedidoBodegas.Find(id);
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


