using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
	public class Ubicaciones
	{
		private SeePOSContext entities;

		public Ubicaciones()
		{
			entities = new SeePOSContext();
		}

		public int Crear(Models.Ubicacione ubicaciones) // registro de Ubicaciones
		{
			try
			{
				entities.Ubicaciones.Add(ubicaciones);
				return entities.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<Models.SubUbicacion> BuscarDetalle(long Id)  //consultar Ubicaciones
		{
			try
			{
				List<Models.SubUbicacion> result;
				
					var temp = from c in entities.SubUbicacions
							   where c.CodUbicacion == Id
							   select c;
					result = temp.ToList<Models.SubUbicacion>();
				
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

		public List<Models.Ubicacione> Buscar(bool porNombre, string filtro)  //consultar Ubicaciones
		{
			try
			{
				List<Models.Ubicacione> result;
				if (porNombre == true)
				{
					var temp = from c in entities.Ubicaciones
							   where c.Descripcion.Contains(filtro) 
							   select c;
					result = temp.ToList<Models.Ubicacione>();
				}
				else
				{
					var temp = from c in entities.Ubicaciones
							   where c.Codigo == Convert.ToInt32(filtro)
							   select c;
					result = temp.ToList<Models.Ubicacione>();
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

		public int Editar(int id, Models.Ubicacione Ubicacion) //editar Ubicaciones
		{
			try
			{
				var p = entities.Ubicaciones.Find(id);
				Models.Ubicacione Ubicaciones = p;
				if (Ubicaciones != null)
				{
					Ubicaciones.Codigo = Ubicacion.Codigo;
					Ubicaciones.Descripcion = Ubicacion.Descripcion;
					Ubicaciones.Observaciones = Ubicacion.Observaciones;
					Ubicaciones.Activa = Ubicacion.Activa;

					var ac = from x in entities.SubUbicacions
							 where x.CodUbicacion == id && !(from t in Ubicacion.SubUbicacions select t.Codigo).Contains(x.Codigo)
							 select x;
					List<Models.SubUbicacion> Eliminar = ac.ToList<Models.SubUbicacion>();

					foreach (Models.SubUbicacion item in Eliminar)
					{
						var del = entities.SubUbicacions.Find(item.Codigo);
						entities.Remove(del);
						entities.SaveChanges();
					}

					Models.SubUbicacion nuevaLinea;
					foreach (Models.SubUbicacion Detalle in Ubicacion.SubUbicacions)
					{
						//Agrega nuevos registros
						if (Detalle.Codigo == "0")
						{
							nuevaLinea = new Models.SubUbicacion();
							nuevaLinea.CodUbicacion = Detalle.CodUbicacion;
							nuevaLinea.CodSubUbicacion = Detalle.CodSubUbicacion;
							nuevaLinea.DescripcionD = Detalle.DescripcionD;
							nuevaLinea.Observaciones = Detalle.Observaciones;
							Ubicaciones.SubUbicacions.Add(nuevaLinea);
						}
						else
						{
							//Actualiza los detalles
							var a = entities.SubUbicacions.Find(Detalle.Codigo);
							Models.SubUbicacion lineaModificada = a;
							if (lineaModificada != null)
							{
								lineaModificada.CodUbicacion = Detalle.CodUbicacion;
								lineaModificada.CodSubUbicacion = Detalle.CodSubUbicacion;
								lineaModificada.Codigo = Detalle.Codigo;
								lineaModificada.DescripcionD = Detalle.DescripcionD;
								lineaModificada.Observaciones = Detalle.Observaciones;

								entities.Entry(lineaModificada).State = EntityState.Modified;
								entities.SaveChanges();
							}
						}

					}

					entities.Entry(Ubicaciones).State = EntityState.Modified;
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

		public int Borrar(int id) //borrar Ubicaciones
		{
			try
			{
				var p = entities.Ubicaciones.Find(id);
				Models.Ubicacione Nuevo = p;
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


