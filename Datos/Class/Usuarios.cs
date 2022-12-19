using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
	public class Usuarios
	{
		private SeePOSContext entities;

		public Usuarios()
		{
			entities = new SeePOSContext();
		}

		public int Crear(Models.Usuario usuarios) // registro de Usuarios
		{
			try
			{
				entities.Usuarios.Add(usuarios);
				return entities.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<Models.Usuario> Buscar(bool porNombre, string filtro)  //consultar Usuarios
		{
			try
			{
				List<Models.Usuario> result;
				if (porNombre == true)
				{
					var temp = from c in entities.Usuarios
							   where c.Nombre.Contains(filtro)
							   orderby c.Nombre
							   select c;
					result = temp.ToList<Models.Usuario>();
				}
				else
				{
					var temp = from c in entities.Usuarios
							   where c.IdUsuario == filtro
							   select c;
					result = temp.ToList<Models.Usuario>();
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

		public int Editar(long id, Models.Usuario nuevo) //editar Usuarios
		{
			try
			{
				var p = entities.Usuarios.Find(id);
				Models.Usuario viejo = p;
				if (viejo != null)
				{
					viejo.IdUsuario = nuevo.IdUsuario;
					viejo.Nombre = nuevo.Nombre;
					viejo.ClaveEntrada = nuevo.ClaveEntrada;
					viejo.ClaveInterna = nuevo.ClaveInterna;
					viejo.Perfil = nuevo.Perfil;
					viejo.Foto = nuevo.Foto;
					viejo.Iniciales = nuevo.Iniciales;
					viejo.CambiarPrecio = nuevo.CambiarPrecio;
					viejo.PorcPrecio = nuevo.PorcPrecio;
					viejo.AplicarDesc = nuevo.AplicarDesc;
					viejo.PorcDesc = nuevo.PorcDesc;
					viejo.ExistNegativa = nuevo.ExistNegativa;
					viejo.idUserAspNet = nuevo.idUserAspNet;

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

		public int Borrar(long id) //borrar Usuarios
		{
			try
			{
				var p = entities.Usuarios.Find(id);
				Models.Usuario Nuevo = p;
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


