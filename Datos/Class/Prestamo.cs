using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
	public class Prestamo
	{
		private SeePOSContext entities;

		public Prestamo()
		{
			entities = new SeePOSContext();
		}

		public int Crear(Models.Prestamo prestamo) // registro de Prestamo
		{
			try
			{
				entities.Prestamos.Add(prestamo);
				return entities.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<Models.DetallePrestamo> BuscarDetalle(long Id)  //consultar Prestamo
		{
			try
			{
				List<Models.DetallePrestamo> result;
					var temp = from c in entities.DetallePrestamos
							   select c;
					result = temp.ToList<Models.DetallePrestamo>();
				
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

		public List<Models.Prestamo> Buscar(bool porNombre, string filtro)  //consultar Prestamo
		{
			try
			{
				List<Models.Prestamo> result;
				if (porNombre == true)
				{
					var temp = from c in entities.Prestamos
							   select c;
					result = temp.ToList<Models.Prestamo>();
				}
				else
				{
					var temp = from c in entities.Prestamos
							   select c;
					result = temp.ToList<Models.Prestamo>();
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

		public int Editar(long id, Models.Prestamo nuevo) //editar Prestamo
		{
			try
			{
				var p = entities.Prestamos.Find(id);
				Models.Prestamo viejo = p;
				if (viejo != null)
				{
					viejo.Id = nuevo.Id;
					viejo.Fecha = nuevo.Fecha;
					viejo.Estado = nuevo.Estado;
					viejo.Anulado = nuevo.Anulado;
					viejo.Entrada = nuevo.Entrada;
					viejo.Salida = nuevo.Salida;
					viejo.Observacion = nuevo.Observacion;
					viejo.NombreDestino = nuevo.NombreDestino;
					viejo.Boleta = nuevo.Boleta;
					viejo.Destinatario = nuevo.Destinatario;
					viejo.NombreDestinatario = nuevo.NombreDestinatario;
					viejo.Destino = nuevo.Destino;
					viejo.Transportista = nuevo.Transportista;
					viejo.IdUsuariCreo = nuevo.IdUsuariCreo;
					viejo.BoletaProveedor = nuevo.BoletaProveedor;

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

		public int Borrar(long id) //borrar Prestamo
		{
			try
			{
				var p = entities.Prestamos.Find(id);
				Models.Prestamo Nuevo = p;
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


