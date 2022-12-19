using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
	public class Familia
	{
		private SeePOSContext entities;

		public Familia()
		{
			entities = new SeePOSContext();
		}

		public int Crear(Models.Familium familia) // registro de Familia
		{
			try
			{
				entities.Familia.Add(familia);
				return entities.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<Models.SubFamilia> BuscarSubFamilia(int CodigoFamilia)
        {
			try
			{
				List<Models.SubFamilia> result;
				
					var temp = from c in entities.SubFamilias
							   where c.CodigoFamilia == CodigoFamilia
							   select c;
					result = temp.ToList<Models.SubFamilia>();
				
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

		public List<Models.Familium> Buscar(bool porNombre, string filtro)  //consultar Familia
		{
			try
			{
				List<Models.Familium> result;
				if (porNombre == true)
				{
					var temp = from fam in entities.Familia							   
							   where fam.Descripcion.Contains(filtro)
							   select fam;
					result = temp.ToList<Models.Familium>();
				}
				else
				{
					var temp = from c in entities.Familia
							   where c.Codigo == Convert.ToInt32(filtro)
							   select c;
					result = temp.ToList<Models.Familium>();
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

		public int Editar(long id, Models.Familium Familia) //editar Familia
		{
			try
			{
				var p = entities.Familia.Find(id);
				Models.Familium Familias = p;
				if (Familias != null)
				{
					Familias.Codigo = Familia.Codigo;
					Familias.Descripcion = Familia.Descripcion;
					Familias.Observaciones = Familia.Observaciones;
					Familias.CuentaGra = Familia.CuentaGra;
					Familias.DescripcionGra = Familia.DescripcionGra;
					Familias.CuentaExe = Familia.CuentaExe;
					Familias.DescripcionExe = Familia.DescripcionExe;
					Familias.CuentaCosto = Familia.CuentaCosto;
					Familias.DescripcionCosto = Familia.DescripcionCosto;

					var ac = from x in entities.SubFamilias
							 where x.CodigoFamilia == id && !(from t in Familia.SubFamilia select t.Codigo).Contains(x.Codigo)
							 select x;
					List<Models.SubFamilia> Eliminar = ac.ToList<Models.SubFamilia>();

					foreach (Models.SubFamilia item in Eliminar)
					{
						var del = entities.SubFamilias.Find(item.Codigo);
						entities.Remove(del);
						entities.SaveChanges();
					}

					Models.SubFamilia nuevaLinea;
					foreach (Models.SubFamilia Detalle in Familias.SubFamilia)
					{
						//Agrega nuevos registros
						if (Detalle.Codigo == "0")
						{
							nuevaLinea = new Models.SubFamilia();
							nuevaLinea.CodigoFamilia = Detalle.CodigoFamilia;
							nuevaLinea.SubCodigo = Detalle.SubCodigo;
							nuevaLinea.Descripcion = Detalle.Descripcion;
							nuevaLinea.Observaciones = Detalle.Observaciones;
							Familias.SubFamilia.Add(nuevaLinea);
						}
						else
						{
							//Actualiza los detalles
							var a = entities.SubFamilias.Find(Detalle.Codigo);
							Models.SubFamilia lineaModificada = a;
							if (lineaModificada != null)
							{
								lineaModificada.CodigoFamilia = Detalle.CodigoFamilia;
								lineaModificada.SubCodigo = Detalle.SubCodigo;
								lineaModificada.Codigo = Detalle.Codigo;
								lineaModificada.Descripcion = Detalle.Descripcion;
								lineaModificada.Observaciones = Detalle.Observaciones;

								entities.Entry(lineaModificada).State = EntityState.Modified;
								entities.SaveChanges();
							}
						}

					}

					entities.Entry(Familias).State = EntityState.Modified;
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

		public int Borrar(long id) //borrar Familia
		{
			try
			{
				var p = entities.Familia.Find(id);
				Models.Familium Nuevo = p;
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


