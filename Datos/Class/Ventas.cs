using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
	public class Ventas
	{
		private SeePOSContext entities;

		public Ventas()
		{
			entities = new SeePOSContext();
		}

		public int Crear(Models.Venta ventas) // registro de PreVentas
		{
			try
			{
				entities.Ventas.Add(ventas);
				return entities.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<Models.VentasDetalle> BuscarDetalle(long Id)  //consultar PreVentas
		{
			try
			{
				List<Models.VentasDetalle> result;
				
					var temp = from c in entities.VentasDetalles
							   where c.IdFactura == Id
							   select c;
					result = temp.ToList<Models.VentasDetalle>();
				
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

		public Models.Venta Obtener(long id)  //consultar PreVentas
		{
			var p = entities.Ventas.Find(id);
			Models.Venta viejo = p;
			if (viejo != null)
			{
				return viejo;
			}
			else
			{
				return null;
			}
		}		

		public List<Models.Venta> Buscar(bool porNombre, string filtro)  //consultar PreVentas
		{
			try
			{
				List<Models.Venta> result;
				if (porNombre == true)
				{
					var temp = from c in entities.Ventas
							   where c.NombreCliente.Contains(filtro)
							   orderby c.Fecha descending
							   select c;
					result = temp.ToList<Models.Venta>();
				}
				else
				{
					var temp = from c in entities.Ventas
							   where c.NumFactura == Convert.ToInt32(filtro)
							   orderby c.Fecha descending
							   select c;
					result = temp.ToList<Models.Venta>();
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

	}
}


