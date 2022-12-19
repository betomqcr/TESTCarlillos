using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
	public class OrdenCompra
	{
		private SeePOSContext entities;

		public OrdenCompra()
		{
			entities = new SeePOSContext();
		}

		public int Crear(Models.Ordencompra ordencompra) // registro de OrdenCompra
		{
			try
			{
				entities.Ordencompras.Add(ordencompra);
				return entities.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<Models.DetalleOrdencompra> BuscarDetalle(long Id)  //consultar OrdenCompra
		{
			try
			{
				List<Models.DetalleOrdencompra> result;
					var temp = from c in entities.DetalleOrdencompras
							   where c.Orden == Id
							   select c;
					result = temp.ToList<Models.DetalleOrdencompra>();
				
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

		public List<Models.Ordencompra> Buscar(bool porNombre, string filtro)  //consultar OrdenCompra
		{
			try
			{
				List<Models.Ordencompra> result;
				if (porNombre == true)
				{
					var temp = from c in entities.Ordencompras
							   where c.Nombre.Contains(filtro)
							   orderby c.Fecha descending
							   select c;
					result = temp.ToList<Models.Ordencompra>();
				}
				else
				{
					var temp = from c in entities.Ordencompras
							   where c.Orden == Convert.ToInt32(filtro)
							   select c;
					result = temp.ToList<Models.Ordencompra>();
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

		public int Editar(long id, Models.Ordencompra Orden) //editar OrdenCompra
		{
			try
			{
				var p = entities.Ordencompras.Find(id);
				Models.Ordencompra OrdenCompra = p;
				if (OrdenCompra != null)
				{					
					OrdenCompra.Proveedor = Orden.Proveedor;
					OrdenCompra.Nombre = Orden.Nombre;
					OrdenCompra.Fecha = Orden.Fecha;
					OrdenCompra.Contado = Orden.Contado;
					OrdenCompra.Credito = Orden.Credito;
					OrdenCompra.Diascredito = Orden.Diascredito;
					OrdenCompra.Plazo = Orden.Plazo;
					OrdenCompra.Descuento = Orden.Descuento;
					OrdenCompra.Impuesto = Orden.Impuesto;
					OrdenCompra.Total = Orden.Total;
					OrdenCompra.Observaciones = Orden.Observaciones;
					OrdenCompra.Usuario = Orden.Usuario;
					OrdenCompra.NombreUsuario = Orden.NombreUsuario;
					OrdenCompra.Entregar = Orden.Entregar;
					OrdenCompra.CodMoneda = Orden.CodMoneda;
					OrdenCompra.SubTotalGravado = Orden.SubTotalGravado;
					OrdenCompra.SubTotalExento = Orden.SubTotalExento;
					OrdenCompra.SubTotal = Orden.SubTotal;
					OrdenCompra.Anulado = Orden.Anulado;

					var ac = from x in entities.DetalleOrdencompras
							 where x.Orden == id && !(from t in Orden.DetalleOrdencompras select t.Id).Contains(x.Id)
							 select x;
					List<Models.DetalleOrdencompra> Eliminar = ac.ToList<Models.DetalleOrdencompra>();

					foreach (Models.DetalleOrdencompra item in Eliminar)
					{
						var del = entities.DetalleOrdencompras.Find(item.Id);
						entities.Remove(del);
						entities.SaveChanges();
					}

					Models.DetalleOrdencompra nuevaLinea;
					foreach (Models.DetalleOrdencompra Detalle in Orden.DetalleOrdencompras)
					{
						//Agrega nuevos registros
						if (Detalle.Id == 0)
						{
							nuevaLinea = new Models.DetalleOrdencompra();
							//nuevaLinea.Id = Detalle.Id;
							//nuevaLinea.Orden = Detalle.Orden;
							nuevaLinea.Codigo = Detalle.Codigo;
							nuevaLinea.Descripcion = Detalle.Descripcion;
							nuevaLinea.CostoUnitario = Detalle.CostoUnitario;
							nuevaLinea.Cantidad = Detalle.Cantidad;
							nuevaLinea.TotalCompra = Detalle.TotalCompra;
							nuevaLinea.PorcDescuento = Detalle.PorcDescuento;
							nuevaLinea.Descuento = Detalle.Descuento;
							nuevaLinea.PorcImpuesto = Detalle.PorcImpuesto;
							nuevaLinea.Impuesto = Detalle.Impuesto;
							nuevaLinea.OtrosCargos = Detalle.OtrosCargos;
							nuevaLinea.MontoFlete = Detalle.MontoFlete;
							nuevaLinea.Costo = Detalle.Costo;
							nuevaLinea.Gravado = Detalle.Gravado;
							nuevaLinea.Exento = Detalle.Exento;
							nuevaLinea.Vendidos = Detalle.Vendidos;
							nuevaLinea.ExistActual = Detalle.ExistActual;
							OrdenCompra.DetalleOrdencompras.Add(nuevaLinea);
						}
						else
						{
							//Actualiza los detalles
							var a = entities.DetalleOrdencompras.Find(Detalle.Id);
							Models.DetalleOrdencompra lineaModificada = a;
							if (lineaModificada != null)
							{
								lineaModificada.Id = Detalle.Id;
								lineaModificada.Orden = Detalle.Orden;
								lineaModificada.Codigo = Detalle.Codigo;
								lineaModificada.Descripcion = Detalle.Descripcion;
								lineaModificada.CostoUnitario = Detalle.CostoUnitario;
								lineaModificada.Cantidad = Detalle.Cantidad;
								lineaModificada.TotalCompra = Detalle.TotalCompra;
								lineaModificada.PorcDescuento = Detalle.PorcDescuento;
								lineaModificada.Descuento = Detalle.Descuento;
								lineaModificada.PorcImpuesto = Detalle.PorcImpuesto;
								lineaModificada.Impuesto = Detalle.Impuesto;
								lineaModificada.OtrosCargos = Detalle.OtrosCargos;
								lineaModificada.MontoFlete = Detalle.MontoFlete;
								lineaModificada.Costo = Detalle.Costo;
								lineaModificada.Gravado = Detalle.Gravado;
								lineaModificada.Exento = Detalle.Exento;
								lineaModificada.Vendidos = Detalle.Vendidos;
								lineaModificada.ExistActual = Detalle.ExistActual;

								entities.Entry(lineaModificada).State = EntityState.Modified;
								entities.SaveChanges();
							}
						}

					}

					entities.Entry(OrdenCompra).State = EntityState.Modified;
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

		public int Anular(long id) //anular OrdenCompra
		{
			try
			{
				var p = entities.Ordencompras.Find(id);
				Models.Ordencompra viejo = p;
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

	}
}


