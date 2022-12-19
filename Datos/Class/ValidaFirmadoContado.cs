using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
	public class ValidaFirmadoContado
	{
		private SeePOSContext entities;

		public ValidaFirmadoContado()
		{
			entities = new SeePOSContext();
		}

		public int Crear(Models.ValidaFirmadocontado valida) // registro de Familia
		{
			try
			{
				entities.ValidaFirmadocontados.Add(valida);
				return entities.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<Models.ExepcionFirmadocontado> Execion_FirmadoContado(decimal IdValidacion)
        {
			try
			{
				List<Models.ExepcionFirmadocontado> result;
				
					var temp = from c in entities.ExepcionFirmadocontados
							   where c.IdValidaFirmadocontado == IdValidacion
							   select c;
					result = temp.ToList<Models.ExepcionFirmadocontado>();
				
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

		public List<Models.ValidaFirmadocontado> Buscar()  //consultar ValidaFirmadoContado
		{
			try
			{
				List<Models.ValidaFirmadocontado> result;
				
				var temp = from fam in entities.ValidaFirmadocontados							   
							//where fam.IdValidaFirmadocontado
							select fam;
				result = temp.ToList<Models.ValidaFirmadocontado>();
				
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

		public int Editar(long id, Models.ValidaFirmadocontado Valida) //editar Familia
		{
			try
			{
				var p = entities.ValidaFirmadocontados.Find(id);
				Models.ValidaFirmadocontado VFC = p;
				if (VFC != null)
				{
					VFC.Contado = Valida.Contado;
					VFC.Pve = Valida.Pve;
					VFC.MontoMaximo = Valida.MontoMaximo;
					VFC.ExigeNombre = Valida.ExigeNombre;
					VFC.MaximoCliente = Valida.MaximoCliente;
					VFC.MaximoAutoriza = Valida.MaximoAutoriza;
					VFC.MaximoRetira = Valida.MaximoRetira;

					var ac = from x in entities.ExepcionFirmadocontados
							 where x.IdValidaFirmadocontado == id && !(from t in Valida.ExepcionFirmadocontados select t.IdValidaFirmadocontado).Contains(x.IdValidaFirmadocontado)
							 select x;
					List<Models.ExepcionFirmadocontado> Eliminar = ac.ToList<Models.ExepcionFirmadocontado>();

					foreach (Models.ExepcionFirmadocontado item in Eliminar)
					{
						var del = entities.ExepcionFirmadocontados.Find(item.IdExepcionFirmadocontado);
						entities.Remove(del);
						entities.SaveChanges();
					}

					Models.ExepcionFirmadocontado nuevaLinea;
					foreach (Models.ExepcionFirmadocontado Detalle in VFC.ExepcionFirmadocontados)
					{
						//Agrega nuevos registros
						if (Detalle.IdExepcionFirmadocontado == 0)
						{
							nuevaLinea = new Models.ExepcionFirmadocontado();
							nuevaLinea.Cedula = Detalle.Cedula;
							nuevaLinea.Nombre = Detalle.Nombre;
							VFC.ExepcionFirmadocontados.Add(nuevaLinea);
						}
						else
						{
							//Actualiza los detalles
							var a = entities.ExepcionFirmadocontados.Find(Detalle.IdExepcionFirmadocontado);
							Models.ExepcionFirmadocontado lineaModificada = a;
							if (lineaModificada != null)
							{
								lineaModificada.Cedula = Detalle.Cedula;
								lineaModificada.Nombre = Detalle.Nombre;
								entities.Entry(lineaModificada).State = EntityState.Modified;
								entities.SaveChanges();
							}
						}
					}

					entities.Entry(VFC).State = EntityState.Modified;
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

		public int Borrar(decimal id) //borrar Familia
		{
			try
			{
				var p = entities.ValidaFirmadocontados.Find(id);
				Models.ValidaFirmadocontado Nuevo = p;
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


