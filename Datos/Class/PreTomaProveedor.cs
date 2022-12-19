using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
	public class PreTomaProveedor
	{
		private SeePOSContext entities;

		public PreTomaProveedor()
		{
			entities = new SeePOSContext();
		}

		public int Crear(Models.PreTomaProveedor pretomaproveedor) // registro de PreTomaProveedor
		{
			try
			{
				entities.PreTomaProveedors.Add(pretomaproveedor);
				return entities.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<Models.PreTomaProveedorDetalle> BuscarDetalle(decimal Id)  //consultar PreTomaProveedor
		{
			try
			{
				List<Models.PreTomaProveedorDetalle> result;
					var temp = from c in entities.PreTomaProveedorDetalles
							   where c.IdPreTomaProveedor == Id
							   select c;
					result = temp.ToList<Models.PreTomaProveedorDetalle>();
				
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

		public List<Models.PreTomaProveedor> Buscar(bool porNombre, string filtro)  //consultar PreTomaProveedor
		{
			try
			{
				List<Models.PreTomaProveedor> result;
				if (porNombre == true)
				{
					var temp = from c in entities.PreTomaProveedors
							   select c;
					result = temp.ToList<Models.PreTomaProveedor>();
				}
				else
				{
					var temp = from c in entities.PreTomaProveedors
							   select c;
					result = temp.ToList<Models.PreTomaProveedor>();
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

		public int Editar(decimal id, Models.PreTomaProveedor nuevo) //editar PreTomaProveedor
		{
			try
			{
				var p = entities.PreTomaProveedors.Find(id);
				Models.PreTomaProveedor viejo = p;
				if (viejo != null)
				{
					viejo.Id = nuevo.Id;
					viejo.IdUsuarioCreo = nuevo.IdUsuarioCreo;
					viejo.CodigoProv = nuevo.CodigoProv;
					viejo.Fecha = nuevo.Fecha;
					viejo.Anulado = nuevo.Anulado;
					viejo.Usado = nuevo.Usado;

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

		public int Borrar(decimal id) //borrar PreTomaProveedor
		{
			try
			{
				var p = entities.PreTomaProveedors.Find(id);
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


