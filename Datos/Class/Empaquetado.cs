using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
	public class Empaquetado
	{
		private SeePOSContext entities;

		public Empaquetado()
		{
			entities = new SeePOSContext();
		}

		private int DevolucionEmpaquetada(long IdVentaDetalle)
        {
			try
			{
				var p = entities.ArticulosVentasDevueltos.Find(IdVentaDetalle);
				Models.ArticulosVentasDevuelto viejo = p;
				if (viejo != null)
				{
					viejo.Empaquetado = true;					
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

		private int FacturaEmpaquetada(long IdVentaDetalle)
		{

			try
			{
				var p = entities.PreVentasDetalles.Find(IdVentaDetalle);
				Models.PreVentasDetalle viejo = p;
				if (viejo != null)
				{
					viejo.Empaquetado = true;
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

		public int Crear(Models.Empaquetado empaquetado) // registro de Empaquetado
		{
			try
			{
				int resultado = 0;
				// RE == Devoluciones
				// EN == Facturas
				if(empaquetado.Tipo == "RE")
                {
					// Esta empaquetando una devolucion
					resultado = this.DevolucionEmpaquetada(empaquetado.IdVentaDetalle);
                }
                else 
                {
					// Esta empaquetando una factura
					resultado = this.FacturaEmpaquetada(empaquetado.IdVentaDetalle);
				}

				if (resultado == 1)
                {
					entities.Empaquetados.Add(empaquetado);
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

		public List<Models.DetalleEmpaquetado> BuscarDetalleEmpaquetado(int CodMarca)  //consultar Empaquetado
		{
			try
			{
				List<Models.DetalleEmpaquetado> result;
				if (CodMarca == 0)
				{
					var temp = from c in entities.DetalleEmpaquetados
							   orderby c.Fecha descending
							   select c;
					result = temp.ToList<Models.DetalleEmpaquetado>();
				}
				else
				{
					var temp = from c in entities.DetalleEmpaquetados
							   where c.CodMarca == CodMarca
							   orderby c.Fecha descending
							   select c;
					result = temp.ToList<Models.DetalleEmpaquetado>();
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

		public int Editar(long id, Models.Empaquetado nuevo) //editar Empaquetado
		{
			try
			{
				var p = entities.Empaquetados.Find(id);
				Models.Empaquetado viejo = p;
				if (viejo != null)
				{
					viejo.IdVentaDetalle = nuevo.IdVentaDetalle;
					viejo.Nombre = nuevo.Nombre;
					viejo.Cedula = nuevo.Cedula;
					viejo.Fecha = nuevo.Fecha;
					viejo.Timer = nuevo.Timer;
					viejo.Factura = nuevo.Factura;
					viejo.Tipo = nuevo.Tipo;

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

		public int Borrar(long id) //borrar Empaquetado
		{
			try
			{
				var p = entities.Empaquetados.Find(id);
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


