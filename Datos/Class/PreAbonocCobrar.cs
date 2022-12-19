using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
	public class PreAbonocCobrar
	{
		private SeePOSContext entities;

		public PreAbonocCobrar()
		{
			entities = new SeePOSContext();
		}

		public int Crear(Models.PreAbonocCobrar preabonoccobrar) // registro de PreAbonocCobrar
		{
			try
			{
				entities.PreAbonocCobrars.Add(preabonoccobrar);
				return entities.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public Models.PreAbonocCobrar Obtener(long id)  //consultar 
		{
			var p = entities.PreAbonocCobrars.Find(id);
			Models.PreAbonocCobrar viejo = p;
			if (viejo != null)
			{
				return viejo;
			}
			else
			{
				return null;
			}
		}

		public List<Models.DetallePreAbonocCobrar> BuscarDetalle(long Id)  //consultar PreAbonocCobrar
		{
			try
			{
				List<Models.DetallePreAbonocCobrar> result;
					var temp = from c in entities.DetallePreAbonocCobrars
							   where c.IdRecibo == Id
							   select c;
					result = temp.ToList<Models.DetallePreAbonocCobrar>();
				
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

		public List<Models.PreAbonocCobrar> Buscar(bool porNombre, string filtro)  //consultar PreAbonocCobrar
		{
			try
			{
				List<Models.PreAbonocCobrar> result;
				if (porNombre == true)
				{
					var temp = from c in entities.PreAbonocCobrars
							   select c;
					result = temp.ToList<Models.PreAbonocCobrar>();
				}
				else
				{
					var temp = from c in entities.PreAbonocCobrars
							   select c;
					result = temp.ToList<Models.PreAbonocCobrar>();
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

		public int Editar(long id, Models.PreAbonocCobrar nuevo) //editar PreAbonocCobrar
		{
			try
			{
				var p = entities.PreAbonocCobrars.Find(id);
				Models.PreAbonocCobrar viejo = p;
				if (viejo != null)
				{
					viejo.IdRecibo = nuevo.IdRecibo;
					viejo.NumRecibo = nuevo.NumRecibo;
					viejo.CodCliente = nuevo.CodCliente;
					viejo.NombreCliente = nuevo.NombreCliente;
					viejo.SaldoCuenta = nuevo.SaldoCuenta;
					viejo.Monto = nuevo.Monto;
					viejo.SaldoActual = nuevo.SaldoActual;
					viejo.Fecha = nuevo.Fecha;
					viejo.Observaciones = nuevo.Observaciones;
					viejo.Anula = nuevo.Anula;
					viejo.CedUsuario = nuevo.CedUsuario;
					viejo.Contabilizado = nuevo.Contabilizado;
					viejo.Asiento = nuevo.Asiento;
					viejo.CodMoneda = nuevo.CodMoneda;
					viejo.Cheque = nuevo.Cheque;
					viejo.NumCaja = nuevo.NumCaja;
					viejo.Banco = nuevo.Banco;
					viejo.Ficha = nuevo.Ficha;
					viejo.Estado = nuevo.Estado;

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

		public int Borrar(long id) //borrar PreAbonocCobrar
		{
			try
			{
				var p = entities.PreAbonocCobrars.Find(id);
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


