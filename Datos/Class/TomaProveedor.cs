using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
	public class TomaProveedor
	{
		private SeePOSContext entities;

		public TomaProveedor()
		{
			entities = new SeePOSContext();
		}

		public int Crear(Models.TomaProveedor tomaproveedor) // registro de TomaProveedor
		{
			try
			{
				entities.TomaProveedors.Add(tomaproveedor);
				return entities.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<Models.TomaProveedorDetalle> BuscarDetalle(decimal Id)  //consultar TomaProveedor
		{
			try
			{
				List<Models.TomaProveedorDetalle> result;
					var temp = from c in entities.TomaProveedorDetalles
							   select c;
					result = temp.ToList<Models.TomaProveedorDetalle>();
				
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

		public List<Models.TomaProveedor> Buscar(bool porNombre, string filtro)  //consultar TomaProveedor
		{
			try
			{
				List<Models.TomaProveedor> result;
				if (porNombre == true)
				{
					var temp = from c in entities.TomaProveedors
							   select c;
					result = temp.ToList<Models.TomaProveedor>();
				}
				else
				{
					var temp = from c in entities.TomaProveedors
							   select c;
					result = temp.ToList<Models.TomaProveedor>();
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

		public int Editar(decimal id, Models.TomaProveedor nuevo) //editar TomaProveedor
		{
			try
			{
				var p = entities.TomaProveedors.Find(id);
				Models.TomaProveedor viejo = p;
				if (viejo != null)
				{
					viejo.Id = nuevo.Id;
					viejo.IdUsuarioCreo = nuevo.IdUsuarioCreo;
					viejo.CodigoProv = nuevo.CodigoProv;
					viejo.Fecha = nuevo.Fecha;
					viejo.Anulado = nuevo.Anulado;
					viejo.Aplicado = nuevo.Aplicado;

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

		public int Borrar(decimal id) //borrar TomaProveedor
		{
			try
			{
				var p = entities.TomaProveedors.Find(id);
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


