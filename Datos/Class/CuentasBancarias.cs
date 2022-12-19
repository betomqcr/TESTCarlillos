using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
	public class CuentasBancarias
	{
		private SeePOSContext entities;

		public CuentasBancarias()
		{
			entities = new SeePOSContext();
		}

		public int Crear(Models.CuentasBancaria cuentas_bancarias) // registro de Cuentas_Bancarias
		{
			try
			{
				entities.CuentasBancarias.Add(cuentas_bancarias);
				return entities.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<Models.CuentasBancaria> CuentasxCodigoBanco(long codigo)  //consultar Cuentas_Bancarias
		{
			try
			{
				List<Models.CuentasBancaria> result;
				var temp = from c in entities.CuentasBancarias
						   where c.CodigoBanco == codigo
						   select c;
				result = temp.ToList<Models.CuentasBancaria>();
				
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

		public List<Models.CuentasBancaria> Buscar(bool porNombre, string filtro)  //consultar Cuentas_Bancarias
		{
			try
			{
				List<Models.CuentasBancaria> result;
				if (porNombre == true)
				{
					var temp = from c in entities.CuentasBancarias
							   where c.Cuenta.Contains(filtro)
							   orderby c.Cuenta
							   select c;
					result = temp.ToList<Models.CuentasBancaria>();
				}
				else
				{
					var temp = from c in entities.CuentasBancarias
							   where c.IdCuentaBancaria == Convert.ToInt32(filtro)
							   select c;
					result = temp.ToList<Models.CuentasBancaria>();
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

		public int Editar(long id, Models.CuentasBancaria nuevo) //editar Cuentas_Bancarias
		{
			try
			{
				var p = entities.CuentasBancarias.Find(id);
				Models.CuentasBancaria viejo = p;
				if (viejo != null)
				{
					viejo.Cuenta = nuevo.Cuenta;
					viejo.CodigoBanco = nuevo.CodigoBanco;
					viejo.TipoCuenta = nuevo.TipoCuenta;
					viejo.NombreCuenta = nuevo.NombreCuenta;
					viejo.SaldoInicial = nuevo.SaldoInicial;
					viejo.CuentaContable = nuevo.CuentaContable;
					viejo.ChequeInicial = nuevo.ChequeInicial;
					viejo.ChequeFinal = nuevo.ChequeFinal;
					viejo.CodMoneda = nuevo.CodMoneda;
					viejo.IdCuentaBancaria = nuevo.IdCuentaBancaria;
					viejo.NombreCuentaContable = nuevo.NombreCuentaContable;
					viejo.Fecha = nuevo.Fecha;

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

		public int Borrar(long id) //borrar Cuentas_Bancarias
		{
			try
			{
				var p = entities.CuentasBancarias.Find(id);
				Models.CuentasBancaria Nuevo = p;
				if (Nuevo != null)
				{
					entities.Remove(p);
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
	}
}


