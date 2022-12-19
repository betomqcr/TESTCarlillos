using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
	public class PreVentas
	{
		private SeePOSContext entities;

		public PreVentas()
		{
			entities = new SeePOSContext();
		}

#region ProcedimientoFacturarPreventa
        private Models.Venta Preventa2Venta(long IdPreventa, string Tipo, DateTime Fecha, int Apertura, long Caja, int IdEmpresa) //Convierte una Preventa en una Venta
		{
			//Convierte una Preventa en una Venta
			var pre = new Models.PreVenta();
			var predet = new List<Models.PreVentasDetalle>();
			//Obtenermos Preventa
			pre = this.Obtener(IdPreventa);
			predet = this.BuscarDetalle(IdPreventa);

			//Creamos y asignamos el valor de Ventas
			var ve = new Models.Venta();			
			//ve.Id = pre.Id;
			ve.NumFactura = pre.NumFactura;
			ve.Tipo = Tipo;
			ve.CodCliente = pre.CodCliente;
			ve.NombreCliente = pre.NombreCliente;
			ve.Orden = pre.Orden;
			ve.CedulaUsuario = pre.CedulaUsuario;
			ve.PagoComision = pre.PagoComision;
			ve.SubTotal = pre.SubTotal;
			ve.Descuento = pre.Descuento;
			ve.ImpVenta = pre.ImpVenta;
			ve.Total = pre.Total;
			ve.Fecha = Fecha;
			ve.Vence = pre.Vence;//Ojo
			ve.CodEncargadoCompra = pre.CodEncargadoCompra;
			ve.Contabilizado = pre.Contabilizado;
			ve.AsientoVenta = pre.AsientoVenta;
			ve.ContabilizadoCventa = pre.ContabilizadoCventa;
			ve.AsientoCosto = pre.AsientoCosto;
			ve.Anulado = pre.Anulado;
			ve.PagoImpuesto = pre.PagoImpuesto;
			ve.FacturaCancelado = pre.FacturaCancelado;
			ve.NumApertura = Apertura;
			ve.Entregado = pre.Entregado;
			ve.CodMoneda = pre.CodMoneda;
			ve.MonedaNombre = pre.MonedaNombre;
			ve.Direccion = pre.Direccion;
			ve.Telefono = pre.Telefono;
			ve.SubTotalGravada = pre.SubTotalGravada;
			ve.SubTotalExento = pre.SubTotalExento;
			ve.Transporte = pre.Transporte;
			ve.TipoCambio = pre.TipoCambio;
			ve.Observaciones = pre.Observaciones;
			ve.Exonerar = pre.Exonerar;
			ve.Taller = pre.Taller;
			ve.Mascotas = pre.Mascotas;
			ve.NumCaja = Caja;
			ve.Agente = pre.Agente;
			ve.CodAgente = pre.CodAgente;
			ve.Apartado = pre.Apartado;
			ve.EnviadoMh = pre.EnviadoMh;
			ve.Cedula = pre.Cedula;
			ve.ClaveMh = pre.ClaveMh;
			ve.EstadoMh = pre.EstadoMh;
			ve.TipoCedula = pre.TipoCedula;
			ve.ConsecutivoMh = pre.ConsecutivoMh;
			ve.ExcluirCxC = pre.ExcluirCxC;
			ve.IdAdelanto = 0; // pre.IdAdelanto;
			ve.Reenviar = false;// pre.Reenviar;
			ve.NumeroReenvio = 0;// pre.NumeroReenvio;
			ve.ClaveReenvio = "";// pre.ClaveReenvio;
			ve.ConsecutivoReenvio = "";// pre.ConsecutivoReenvio;
			ve.Archivada = false;// pre.Archivada;
			ve.UsuarioArchivo = "";// pre.UsuarioArchivo;
			ve.FechaArchivo = DateTime.Now;// pre.FechaArchivo;
			ve.Frecuente = pre.Frecuente;
			ve.IdFacturaRemplaza = pre.IdFacturaRemplaza;
			ve.Renta = false;// pre.Renta;
			ve.Etapa = 0; // pre.Etapa;
			ve.FechaEtapa = DateTime.Now;// pre.FechaEtapa;
			ve.EnProcesoIncobrable = false;// pre.EnProcesoIncobrable;
			ve.IdEmpresa = IdEmpresa;// pre.idEmpresa;

			foreach (Models.PreVentasDetalle row in predet)
			{
				var vedet = new Models.VentasDetalle();
				//vedet.IdVentaDetalle = row.IdVentaDetalle;
				//vedet.IdFactura = row.IdFactura;
				vedet.Codigo = row.Codigo;
				vedet.CodArticulo = row.CodArticulo;
				vedet.Descripcion = row.Descripcion;
				vedet.Cantidad = row.Cantidad;
				vedet.PrecioCosto = row.PrecioCosto;
				vedet.PrecioBase = row.PrecioBase;
				vedet.PrecioFlete = row.PrecioFlete;
				vedet.PrecioOtros = row.PrecioOtros;
				vedet.PrecioUnit = row.PrecioUnit;
				vedet.Descuento = row.Descuento;
				vedet.MontoDescuento = row.MontoDescuento;
				vedet.Impuesto = row.Impuesto;
				vedet.MontoImpuesto = row.MontoImpuesto;
				vedet.SubtotalGravado = row.SubtotalGravado;
				vedet.SubTotalExcento = row.SubTotalExcento;
				vedet.SubTotal = row.SubTotal;
				vedet.Devoluciones = row.Devoluciones;
				vedet.NumeroEntrega = row.NumeroEntrega;
				vedet.MaxDescuento = row.MaxDescuento;
				vedet.TipoCambioValorCompra = row.TipoCambioValorCompra;
				vedet.CodMonedaVenta = row.CodMonedaVenta;
				vedet.Lote = row.Lote;
				vedet.CantVet = row.CantVet;
				vedet.CantBod = row.CantBod;
				vedet.Disminuye = row.Disminuye;
				vedet.Empaquetado = row.Empaquetado;
				vedet.NotaPantalla = row.NotaPantalla;
				vedet.IdBodega = row.IdBodega;
				vedet.Regalias = row.Regalias;
				vedet.CostoReal = row.CostoReal;
				vedet.IdTipoExoneracion = row.IdTipoExoneracion;
				vedet.NumeroDocumento = row.NumeroDocumento;
				vedet.FechaEmision = row.FechaEmision;
				vedet.PorcentajeCompra = decimal.ToDouble( row.PorcentajeCompra);
				vedet.IdImpuesto = 0;// datos.IdImpuesto;
				vedet.Entregado = row.Entregado;
				vedet.Entregados = row.Entregados;
				vedet.IdSerie = row.IdSerie;

				ve.VentasDetalles.Add(vedet);
			}

			return ve;
		}
		private int CambiarEstadoCotizacion(decimal IdCotizacion, long IdFactura) //Cambiar Estado Cotizacion
		{
			try
			{
				var cot = entities.Cotizacions.Find(IdCotizacion);
				Models.Cotizacion viejo = cot;
				if (viejo != null)
				{
					viejo.EstadoActual = "Ganada";
					viejo.ObservacionEstado = "cambio estado automatico por sistema";
					viejo.IdFactura = IdFactura;
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
		private int CambiarEstadoPreventa(long IdPreventa, long IdFactura) //Cambiar Estado Factura
		{
			try
			{
				var preventa = entities.PreVentas.Find(IdPreventa);
				Models.PreVenta viejo = preventa;
				if (viejo != null)
				{
					viejo.Estado = "Venta";
					viejo.IdFactura = IdFactura;
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
		public long Facturar_PreVenta(long IdPreventa, string Tipo, string IdUsuario, int IdEmpresa)
        {

			//Obtener datos Apertura de Caja
			int apertura = (from c in entities.Aperturacajas
						   where c.Cedula == IdUsuario && c.Estado == "A"						   
							select c.Napertura).FirstOrDefault();
			long caja = (from c in entities.Aperturacajas
							where c.Cedula == IdUsuario && c.Estado == "A"
							select c.NumCaja).FirstOrDefault();

			//Obtener la Fecha Actual
			DateTime Fecha;
			Fecha = DateTime.Now;

			//Creamos la Factura apartir de la preventa
			var cls = new Datos.Class.Ventas();
			var NuevaVenta = new Models.Venta();
			NuevaVenta = this.Preventa2Venta(IdPreventa, Tipo,Fecha,apertura, caja,IdEmpresa);
			cls.Crear(NuevaVenta);

			//Marcamos la Preventa como Facturada
			this.CambiarEstadoPreventa(IdPreventa, NuevaVenta.Id);

			//Actualizamos el estado de la cotizacion
			var pre = new Models.PreVenta();
			pre = this.Obtener(IdPreventa);
			if(pre.IdCotizacion > 0)
            {
				this.CambiarEstadoCotizacion(pre.IdCotizacion, NuevaVenta.Id);
            }

			return NuevaVenta.Id;
        }
        #endregion

#region ProcedimentoGenerarReciboCxC
		private Models.Abonoccobrar PreAbono2Abono(long IdAbono, string IdUsuario, DateTime Fecha, int IdEmpresa, decimal NApertura)
        {
			var cxc = new Datos.Class.PreAbonocCobrar();
			var pre = new Models.PreAbonocCobrar();
			var predet = new List<DetallePreAbonocCobrar>();
			pre = cxc.Obtener(IdAbono);
			predet = cxc.BuscarDetalle(IdAbono);

			var abono = new Models.Abonoccobrar();
			//abono.IdRecibo = pre.IdRecibo;
			abono.NumRecibo = pre.NumRecibo;
			abono.CodCliente = pre.CodCliente;
			abono.NombreCliente = pre.NombreCliente;
			abono.SaldoCuenta = pre.SaldoCuenta;
			abono.Monto = pre.Monto;
			abono.SaldoActual = pre.SaldoActual;
			abono.Fecha = Fecha;
			abono.Observaciones = pre.Observaciones;
			abono.Anula = pre.Anula;
			abono.CedUsuario = pre.CedUsuario;
			abono.Contabilizado = pre.Contabilizado;
			abono.Asiento = pre.Asiento;
			abono.CodMoneda = pre.CodMoneda;
			abono.Cheque = pre.Cheque;
			abono.NumCaja = pre.NumCaja;
			abono.Banco = pre.Banco;
			abono.NumApertura = NApertura;
			abono.EstadoEnvio = "";
			abono.IdSucursal = IdEmpresa;

			foreach (Models.DetallePreAbonocCobrar row in predet)
			{
				var abodet = new Models.DetalleAbonoccobrar();
				//abodet.Consecutivo = row.Consecutivo;
				//abodet.IdRecibo = row.IdRecibo;
				abodet.Factura = row.Factura;
				abodet.Tipo = row.Tipo;
				abodet.Fecha = row.Fecha;
				abodet.Monto = row.Monto;
				abodet.SaldoAnt = row.SaldoAnt;
				abodet.Intereses = row.Intereses;
				abodet.Abono = row.Abono;
				abodet.AbonoSuMoneda = row.AbonoSuMoneda;
				abodet.Saldo = row.Saldo;
				abono.DetalleAbonoccobrars.Add(abodet);
			}

			return abono;
        }
		private int CambiarEstadoPreabono(long IdPreAbono) //Cambiar Estado PreAbonoccobrar
		{
			try
			{
				var preventa = entities.PreAbonocCobrars.Find(IdPreAbono);
				Models.PreAbonocCobrar viejo = preventa;
				if (viejo != null)
				{
					viejo.Estado = "Abono";
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
		public long Generar_ReciboDinero(long IdPreAbono, string IdUsuario, int IdEmpresa)
        {
			//Obtener datos Apertura de Caja
			int apertura = (from c in entities.Aperturacajas
							where c.Cedula == IdUsuario && c.Estado == "A"
							select c.Napertura).FirstOrDefault();

			//Obtener la Fecha Actual
			DateTime Fecha;
			Fecha = DateTime.Now;

			//Creamos el recibo apartir del prerecibo
			var cls = new Datos.Class.AbonosCobros();
			var NuevoRecibo = new Models.Abonoccobrar();
			NuevoRecibo = this.PreAbono2Abono(IdPreAbono,IdUsuario,Fecha,IdEmpresa,apertura );
			cls.CrearAbonoCobro(NuevoRecibo);

			//Marcamos el preabono como registrado
			this.CambiarEstadoPreabono(IdPreAbono);

			return NuevoRecibo.IdRecibo;
		}
#endregion

#region ProcedimientoApartar_Preventa

		private Models.Apartado Preventa2Apartado(long IdPreventa, DateTime Fecha, int IdEmpresa, double MontoInicial)
        {
			//Convierte una Preventa en un Apartado
			var pre = new Models.PreVenta();
			var predet = new List<Models.PreVentasDetalle>();
			//Obtenermos Preventa
			pre = this.Obtener(IdPreventa);
			predet = this.BuscarDetalle(IdPreventa);

			//Creamos y asignamos el valor de Ventas
			var apa = new Models.Apartado();
			//apa.IdApartado = pre.IdApartado;
			apa.IdCliente = pre.CodCliente;
			apa.Nombrecliente = pre.NombreCliente;
			apa.Cedulausuario = pre.CedulaUsuario;
			apa.SubTotal = pre.SubTotal;
			apa.ImpVenta = pre.ImpVenta;
			apa.Total = pre.Total;
			apa.Fecha = Fecha;
			apa.Vence = pre.Vence;
			apa.Anulado = pre.Anulado;
			apa.Cancelado = false;
			apa.SubTotalGravada = pre.SubTotalGravada;
			apa.SubTotalExento = pre.SubTotalExento;
			apa.Observaciones = pre.Observaciones;
			apa.Monto = MontoInicial;
			apa.Descuento = pre.Descuento;
			apa.TipoCambio = pre.TipoCambio;
			apa.CodMoneda = pre.CodMoneda;
			apa.IdSucursal = IdEmpresa;

			foreach (Models.PreVentasDetalle row in predet)
			{
				var apadet = new Models.ApartadoDetalle();
				//apadet.IdDetalle = row.Iddetalle;
				//apadet.IdApartado = row.IdApartado;
				apadet.Codigo = row.Codigo.ToString();
				apadet.Descripcion = row.Descripcion;
				apadet.Cantidad = Convert.ToInt32(row.Cantidad);
				apadet.PrecioCosto = row.PrecioCosto;
				apadet.PrecioBase = row.PrecioBase;
				apadet.PrecioFlete = row.PrecioFlete;
				apadet.PrecioOtros = row.PrecioOtros;
				apadet.PrecioUnit = row.PrecioUnit;
				apadet.Impuesto = row.Impuesto;
				apadet.MontoImpuesto = row.MontoImpuesto;
				apadet.SubtotalGravado = row.SubtotalGravado;
				apadet.SubTotalExcento = row.SubTotalExcento;
				apadet.SubTotal = row.SubTotal;
				apadet.MontoDescuento = row.MontoDescuento;
				apadet.Descuento = row.Descuento;
				apadet.MaxDescuento = row.MaxDescuento;
				apadet.TipoCambioValorCompra = row.TipoCambioValorCompra;
				apadet.CodMonedaVenta = row.CodMonedaVenta;
				apadet.IdBodega = 0;
				apadet.CodArticulo = row.CodArticulo;

				apa.ApartadoDetalles.Add(apadet);
			}


			return apa;
		}
		private int CambiarEstadoPreventa(long IdPreventa) //Cambiar Estado Factura
		{
			try
			{
				var preventa = entities.PreVentas.Find(IdPreventa);
				Models.PreVenta viejo = preventa;
				if (viejo != null)
				{
					viejo.Estado = "Apartado";
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
		public long Apartar_Preventa(long IdPreventa, string IdUsuario, int IdEmpresa, double MontoInicial)
        {
			//Obtener datos Apertura de Caja
			int apertura = (from c in entities.Aperturacajas
							where c.Cedula == IdUsuario && c.Estado == "A"
							select c.Napertura).FirstOrDefault();

			//Obtener la Fecha Actual
			DateTime Fecha;
			Fecha = DateTime.Now;

			//Creamos el apartado apartir de la preventa
			var cls = new Datos.Class.Apartados();
			var NuevoApartado = new Models.Apartado();
			NuevoApartado = this.Preventa2Apartado(IdPreventa, Fecha, IdEmpresa, MontoInicial);
			cls.CrearApartados(NuevoApartado);

			//Marcamos el preabono como registrado
			this.CambiarEstadoPreventa(IdPreventa);

			return NuevoApartado.IdApartado;
		}
        #endregion

#region ProcedimientoInsertAbonoReintegro
		public long InsertarAbonoReintegro(Models.Abonoreintegro Abono)
        {

			try
			{
				entities.Abonoreintegros.Add(Abono);
				return entities.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
#endregion

        public int Crear(Models.PreVenta preventas) // registro de PreVentas
		{
			try
			{
				entities.PreVentas.Add(preventas);
				return entities.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<Models.PreVentasDetalle> BuscarDetalle(long Id)  //consultar PreVentas
		{
			try
			{
				List<Models.PreVentasDetalle> result;
				
					var temp = from c in entities.PreVentasDetalles
							   where c.IdFactura == Id
							   select c;
					result = temp.ToList<Models.PreVentasDetalle>();
				
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

		public Models.PreVenta Obtener(long id)  //consultar PreVentas
		{
			var p = entities.PreVentas.Find(id);
			Models.PreVenta viejo = p;
			if (viejo != null)
			{
				return viejo;
			}
			else
			{
				return null;
			}
		}

		public List<Models.ViewPreventasActiva> FichasActivas()  //consultar PreVentas Activas
		{
			try
			{
				List<Models.ViewPreventasActiva> result;
				
					var temp = from c in entities.ViewPreventasActivas							   
							   orderby c.Fecha descending
							   select c;
					result = temp.ToList<Models.ViewPreventasActiva>();
				
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

		public List<Models.PreVenta> Buscar(bool porNombre, string filtro)  //consultar PreVentas
		{
			try
			{
				List<Models.PreVenta> result;
				if (porNombre == true)
				{
					var temp = from c in entities.PreVentas
							   where c.NombreCliente.Contains(filtro)
							   orderby c.Fecha descending
							   select c;
					result = temp.ToList<Models.PreVenta>();
				}
				else
				{
					var temp = from c in entities.PreVentas
							   where c.NumFactura == Convert.ToInt32(filtro)
							   orderby c.Fecha descending
							   select c;
					result = temp.ToList<Models.PreVenta>();
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

		public int Editar(long id, Models.PreVenta preVe) //editar PreVentas
		{
			try
			{
				var c = entities.PreVentas.Find(id);
				Models.PreVenta preVenta = c;
				if (preVenta != null)
				{
					preVenta.Id = preVe.Id;
					preVenta.NumFactura = preVe.NumFactura;
					preVenta.Tipo = preVe.Tipo;
					preVenta.CodCliente = preVe.CodCliente;
					preVenta.NombreCliente = preVe.NombreCliente;
					preVenta.Orden = preVe.Orden;
					preVenta.CedulaUsuario = preVe.CedulaUsuario;
					preVenta.PagoComision = preVe.PagoComision;
					preVenta.SubTotal = preVe.SubTotal;
					preVenta.Descuento = preVe.Descuento;
					preVenta.ImpVenta = preVe.ImpVenta;
					preVenta.Total = preVe.Total;
					preVenta.Fecha = preVe.Fecha;
					preVenta.Vence = preVe.Vence;
					preVenta.CodEncargadoCompra = preVe.CodEncargadoCompra;
					preVenta.Contabilizado = preVe.Contabilizado;
					preVenta.AsientoVenta = preVe.AsientoVenta;
					preVenta.ContabilizadoCventa = preVe.ContabilizadoCventa;
					preVenta.AsientoCosto = preVe.AsientoCosto;
					preVenta.Anulado = preVe.Anulado;
					preVenta.PagoImpuesto = preVe.PagoImpuesto;
					preVenta.FacturaCancelado = preVe.FacturaCancelado;
					preVenta.NumApertura = preVe.NumApertura;
					preVenta.Entregado = preVe.Entregado;
					preVenta.CodMoneda = preVe.CodMoneda;
					preVenta.MonedaNombre = preVe.MonedaNombre;
					preVenta.Direccion = preVe.Direccion;
					preVenta.Telefono = preVe.Telefono;
					preVenta.SubTotalGravada = preVe.SubTotalGravada;
					preVenta.SubTotalExento = preVe.SubTotalExento;
					preVenta.Transporte = preVe.Transporte;
					preVenta.TipoCambio = preVe.TipoCambio;
					preVenta.Observaciones = preVe.Observaciones;
					preVenta.Exonerar = preVe.Exonerar;
					preVenta.Taller = preVe.Taller;
					preVenta.Mascotas = preVe.Mascotas;
					preVenta.NumCaja = preVe.NumCaja;
					preVenta.Agente = preVe.Agente;
					preVenta.CodAgente = preVe.CodAgente;
					preVenta.Apartado = preVe.Apartado;
					preVenta.EnviadoMh = preVe.EnviadoMh;
					preVenta.Cedula = preVe.Cedula;
					preVenta.ClaveMh = preVe.ClaveMh;
					preVenta.EstadoMh = preVe.EstadoMh;
					preVenta.TipoCedula = preVe.TipoCedula;
					preVenta.ConsecutivoMh = preVe.ConsecutivoMh;
					preVenta.ExcluirCxC = preVe.ExcluirCxC;
					preVenta.Ficha = preVe.Ficha;
					preVenta.Estado = preVe.Estado;
					preVenta.IdCotizacion = preVe.IdCotizacion;
					preVenta.Frecuente = preVe.Frecuente;
					preVenta.IdFactura = preVe.IdFactura;
					preVenta.IdFacturaRemplaza = preVe.IdFacturaRemplaza;

					var ac = from x in entities.PreVentasDetalles
							 where x.IdFactura == id && !(from t in preVe.PreVentasDetalles select t.IdVentaDetalle).Contains(x.IdVentaDetalle)
							 select x;
					List<Models.PreVentasDetalle> PreventasDetalle = ac.ToList<Models.PreVentasDetalle>();

					foreach (Models.PreVentasDetalle item in PreventasDetalle)
					{
						var p = entities.PreVentasDetalles.Find(item.IdVentaDetalle);
						entities.Remove(p);
						entities.SaveChanges();
					}

					Models.PreVentasDetalle nuevaLinea;
					foreach (Models.PreVentasDetalle Detalle in preVe.PreVentasDetalles)
					{
						//Agrega nuevos registros
						if (Detalle.IdVentaDetalle == 0)
						{
							nuevaLinea = new Models.PreVentasDetalle();
							//nuevaLinea.IdVentaDetalle = Detalle.IdVentaDetalle;
							//nuevaLinea.IdFactura = Detalle.IdFactura;
							nuevaLinea.Codigo = Detalle.Codigo;
							nuevaLinea.CodArticulo = Detalle.CodArticulo;
							nuevaLinea.Descripcion = Detalle.Descripcion;
							nuevaLinea.Cantidad = Detalle.Cantidad;
							nuevaLinea.PrecioCosto = Detalle.PrecioCosto;
							nuevaLinea.PrecioBase = Detalle.PrecioBase;
							nuevaLinea.PrecioFlete = Detalle.PrecioFlete;
							nuevaLinea.PrecioOtros = Detalle.PrecioOtros;
							nuevaLinea.PrecioUnit = Detalle.PrecioUnit;
							nuevaLinea.Descuento = Detalle.Descuento;
							nuevaLinea.MontoDescuento = Detalle.MontoDescuento;
							nuevaLinea.Impuesto = Detalle.Impuesto;
							nuevaLinea.MontoImpuesto = Detalle.MontoImpuesto;
							nuevaLinea.SubtotalGravado = Detalle.SubtotalGravado;
							nuevaLinea.SubTotalExcento = Detalle.SubTotalExcento;
							nuevaLinea.SubTotal = Detalle.SubTotal;
							nuevaLinea.Devoluciones = Detalle.Devoluciones;
							nuevaLinea.NumeroEntrega = Detalle.NumeroEntrega;
							nuevaLinea.MaxDescuento = Detalle.MaxDescuento;
							nuevaLinea.TipoCambioValorCompra = Detalle.TipoCambioValorCompra;
							nuevaLinea.CodMonedaVenta = Detalle.CodMonedaVenta;
							nuevaLinea.Lote = Detalle.Lote;
							nuevaLinea.CantVet = Detalle.CantVet;
							nuevaLinea.CantBod = Detalle.CantBod;
							nuevaLinea.Disminuye = Detalle.Disminuye;
							nuevaLinea.Empaquetado = Detalle.Empaquetado;
							nuevaLinea.NotaPantalla = Detalle.NotaPantalla;
							nuevaLinea.IdBodega = Detalle.IdBodega;
							nuevaLinea.Regalias = Detalle.Regalias;
							nuevaLinea.CostoReal = Detalle.CostoReal;
							nuevaLinea.IdTipoExoneracion = Detalle.IdTipoExoneracion;
							nuevaLinea.NumeroDocumento = Detalle.NumeroDocumento;
							nuevaLinea.FechaEmision = Detalle.FechaEmision;
							nuevaLinea.PorcentajeCompra = Detalle.PorcentajeCompra;
							nuevaLinea.Entregado = Detalle.Entregado;
							nuevaLinea.Entregados = Detalle.Entregados;
							nuevaLinea.IdSerie = Detalle.IdSerie;

							preVenta.PreVentasDetalles.Add(nuevaLinea);
						}
						else
						{
							//Actualiza los detalles
							var a = entities.PreVentasDetalles.Find(Detalle.IdVentaDetalle);
							Models.PreVentasDetalle lineaModificada = a;
							if (lineaModificada != null)
							{
								lineaModificada.Codigo = Detalle.Codigo;
								lineaModificada.CodArticulo = Detalle.CodArticulo;
								lineaModificada.Descripcion = Detalle.Descripcion;
								lineaModificada.Cantidad = Detalle.Cantidad;
								lineaModificada.PrecioCosto = Detalle.PrecioCosto;
								lineaModificada.PrecioBase = Detalle.PrecioBase;
								lineaModificada.PrecioFlete = Detalle.PrecioFlete;
								lineaModificada.PrecioOtros = Detalle.PrecioOtros;
								lineaModificada.PrecioUnit = Detalle.PrecioUnit;
								lineaModificada.Descuento = Detalle.Descuento;
								lineaModificada.MontoDescuento = Detalle.MontoDescuento;
								lineaModificada.Impuesto = Detalle.Impuesto;
								lineaModificada.MontoImpuesto = Detalle.MontoImpuesto;
								lineaModificada.SubtotalGravado = Detalle.SubtotalGravado;
								lineaModificada.SubTotalExcento = Detalle.SubTotalExcento;
								lineaModificada.SubTotal = Detalle.SubTotal;
								lineaModificada.Devoluciones = Detalle.Devoluciones;
								lineaModificada.NumeroEntrega = Detalle.NumeroEntrega;
								lineaModificada.MaxDescuento = Detalle.MaxDescuento;
								lineaModificada.TipoCambioValorCompra = Detalle.TipoCambioValorCompra;
								lineaModificada.CodMonedaVenta = Detalle.CodMonedaVenta;
								lineaModificada.Lote = Detalle.Lote;
								lineaModificada.CantVet = Detalle.CantVet;
								lineaModificada.CantBod = Detalle.CantBod;
								lineaModificada.Disminuye = Detalle.Disminuye;
								lineaModificada.Empaquetado = Detalle.Empaquetado;
								lineaModificada.NotaPantalla = Detalle.NotaPantalla;
								lineaModificada.IdBodega = Detalle.IdBodega;
								lineaModificada.Regalias = Detalle.Regalias;
								lineaModificada.CostoReal = Detalle.CostoReal;
								lineaModificada.IdTipoExoneracion = Detalle.IdTipoExoneracion;
								lineaModificada.NumeroDocumento = Detalle.NumeroDocumento;
								lineaModificada.FechaEmision = Detalle.FechaEmision;
								lineaModificada.PorcentajeCompra = Detalle.PorcentajeCompra;
								lineaModificada.Entregado = Detalle.Entregado;
								lineaModificada.Entregados = Detalle.Entregados;
								lineaModificada.IdSerie = Detalle.IdSerie;

								entities.Entry(lineaModificada).State = EntityState.Modified;
								entities.SaveChanges();
							}
						}
					}

					entities.Entry(preVenta).State = EntityState.Modified;
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

		public int InactivarFicha(long id, string tipo, string puntoventa) //inactivar Fichas
		{
			try
			{

				if (tipo == "ABO")
                {
					var abono = entities.PreAbonocCobrars.Find(id);
					Models.PreAbonocCobrar viejo = abono;
					if (viejo != null)
					{
						viejo.Estado = "Inactivada";
						entities.Entry(viejo).State = EntityState.Modified;
						return entities.SaveChanges();
					}
					else
					{
						return 0;// no se encotro el registro solicitado.
					}
				}
                else
                {
					var preventa = entities.PreVentas.Find(id);
					Models.PreVenta viejo = preventa;
					if (viejo != null)
					{
						viejo.Estado = "Inactivada";
						entities.Entry(viejo).State = EntityState.Modified;
						return entities.SaveChanges();
					}
					else
					{
						return 0;// no se encotro el registro solicitado.
					}
				}


				
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}


