using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
	public class TemperaturaCamara
	{
		private SeePOSContext entities;

		public TemperaturaCamara()
		{
			entities = new SeePOSContext();
		}

		public int Crear(Models.TemperaturaCamara temperaturacamara) // registro de TemperaturaCamara
		{
			try
			{
				entities.TemperaturaCamaras.Add(temperaturacamara);
				return entities.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<Models.TemperaturaCamara> Buscar(bool porNombre, string filtro)  //consultar TemperaturaCamara
		{
			try
			{
				List<Models.TemperaturaCamara> result;
				if (porNombre == true)
				{
					if(filtro == null)
                    {
						var temp = from c in entities.TemperaturaCamaras								   
								   orderby c.Fecha descending
								   select c;						
						result = temp.ToList<Models.TemperaturaCamara>();
					}
                    else
                    {
						var temp = from c in entities.TemperaturaCamaras
								   join u in entities.Usuarios on c.IdUsuario equals u.IdUsuario
								   where u.Nombre.Contains(filtro)
								   orderby c.Fecha descending
								   select c;
						result = temp.ToList<Models.TemperaturaCamara>();
					}

				}
				else
				{
					var temp = from c in entities.TemperaturaCamaras
							   where c.Id == Convert.ToInt32(filtro)
							   orderby c.Fecha descending
							   select c;
					result = temp.ToList<Models.TemperaturaCamara>();
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

		public int Editar(decimal id, Models.TemperaturaCamara nuevo) //editar TemperaturaCamara
		{
			try
			{
				var p = entities.TemperaturaCamaras.Find(id);
				Models.TemperaturaCamara viejo = p;
				if (viejo != null)
				{
					viejo.Id = nuevo.Id;
					viejo.Fecha = nuevo.Fecha;
					viejo.IdUsuario = nuevo.IdUsuario;
					viejo.Temperatura = nuevo.Temperatura;
					viejo.Horario = nuevo.Horario;

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

		public int Borrar(decimal id) //borrar TemperaturaCamara
		{
			try
			{
				var p = entities.TemperaturaCamaras.Find(id);
				Models.TemperaturaCamara Nuevo = p;
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


