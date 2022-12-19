using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
	public class Movimiento_Caja
	{
		private SeePOSContext entities;

		public Movimiento_Caja()
		{
			entities = new SeePOSContext();
		}

		public int Crear(Models.MovimientoCaja movimiento_caja) // registro de Movimiento_Caja
		{
			try
			{
				entities.MovimientoCajas.Add(movimiento_caja);
				return entities.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}


		public List<Models.MovimientoCaja> Buscar(bool porNombre, string filtro)  //consultar Movimiento_Caja
		{
			try
			{
				List<Models.MovimientoCaja> result;
				if (porNombre == true)
				{
					var temp = from c in entities.MovimientoCajas
							   join u in entities.Usuarios on c.Usuario equals u.IdUsuario
							   where u.Nombre.Contains(filtro)
							   select c;
					result = temp.ToList<Models.MovimientoCaja>();
				}
				else
				{
					var temp = from c in entities.MovimientoCajas
							   where c.Id == Convert.ToInt32(filtro)
							   select c;
					result = temp.ToList<Models.MovimientoCaja>();
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

		public int Editar(long id, Models.MovimientoCaja nuevo) //editar Movimiento_Caja
		{
			try
			{
				var p = entities.MovimientoCajas.Find(id);
				Models.MovimientoCaja viejo = p;
				if (viejo != null)
				{
					
					viejo.Entrada = nuevo.Entrada;
					viejo.Salida = nuevo.Salida;
					viejo.Monto = nuevo.Monto;
					viejo.CodMoneda = nuevo.CodMoneda;
					viejo.Usuario = nuevo.Usuario;
					viejo.Fecha = nuevo.Fecha;
					viejo.Observaciones = nuevo.Observaciones;
					viejo.Anulado = nuevo.Anulado;
					viejo.NumApertura = nuevo.NumApertura;
					viejo.TipoCambio = nuevo.TipoCambio;

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

		public int Anular(long id) //anular Movimiento_Caja
		{
			try
			{
				var p = entities.MovimientoCajas.Find(id);
				Models.MovimientoCaja viejo = p;
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

		public int Borrar(long id) //borrar Movimiento_Caja
		{
			try
			{
				var p = entities.MovimientoCajas.Find(id);
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


