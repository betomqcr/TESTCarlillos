using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;


namespace Datos.Class
{
 public   class Cotizacion
    {

        private SeePOSContext entities;

        public Cotizacion()
        {
            entities = new SeePOSContext();
        }

        public int Crear(Models.Cotizacion cotizacion) // crear carta apartir de objeto de creacion
        {
            try
            {
                entities.Cotizacions.Add(cotizacion);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Models.CotizacionDetalle> BuscarDetalleCotizacion(long Cotizacion) //obtener lista CartasdeExoneracion 
        {
            try
            {
                List<Models.CotizacionDetalle> result;
                    var temp = from c in entities.CotizacionDetalles
                               where c.Cotizacion == Cotizacion
                               select c;
                    result = temp.ToList<Models.CotizacionDetalle>();                

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

        public List<Models.Cotizacion> Buscar(bool porNombre, string filtro) //obtener lista CartasdeExoneracion 
        {
            try
            {
                List<Models.Cotizacion> result;

                if (porNombre == true)
                {
                    //busca por la descripcion
                    var temp = from c in entities.Cotizacions
                               where c.NombreCliente.Contains(filtro) // usar un like
                               orderby c.Fecha descending
                               select c;

                    result = temp.ToList<Models.Cotizacion>();
                }
                else
                {
                    //busca por el id de la tabla
                    var temp = from c in entities.Cotizacions
                               where c.Cotizacion1 == Convert.ToInt64(filtro) //convertir el datos de string a long
                               select c;
                    result = temp.ToList<Models.Cotizacion>();
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

        public int Editar(long id, Models.Cotizacion cot)
        {

            //using (var dbContextTransaction = entities.Database.BeginTransaction())
            //{
                int res = 0;
                try
                {
                    var c = entities.Cotizacions.Find(id);
                    Models.Cotizacion Cotizacion = c;

                    if (Cotizacion != null)
                    {
                        Cotizacion.Fecha = cot.Fecha;
                        Cotizacion.CodCliente = cot.CodCliente;
                        Cotizacion.NombreCliente = cot.NombreCliente;
                        Cotizacion.Contacto = cot.Contacto;
                        Cotizacion.Validez = cot.Validez;
                        Cotizacion.TiempoEntrega = cot.TiempoEntrega;
                        Cotizacion.Contado = cot.Contado;
                        Cotizacion.Credito = cot.Credito;
                        Cotizacion.Anulado = cot.Anulado;
                        Cotizacion.Dias = cot.Dias;
                        Cotizacion.Observaciones = cot.Observaciones;
                        Cotizacion.SubTotalGravada = cot.SubTotalGravada;
                        Cotizacion.SubTotalExento = cot.SubTotalExento;
                        Cotizacion.Descuento = cot.Descuento;
                        Cotizacion.PagoImpuesto = cot.PagoImpuesto;
                        Cotizacion.Total = cot.Total;
                        Cotizacion.Cedula = cot.Cedula;
                        Cotizacion.CodMoneda = cot.CodMoneda;
                        Cotizacion.MonedaNombre = cot.MonedaNombre;
                        Cotizacion.SubTotal = cot.SubTotal;
                        Cotizacion.TipoCambio = cot.TipoCambio;
                        Cotizacion.ImpVenta = cot.ImpVenta;
                        Cotizacion.Transporte = cot.Transporte;
                        Cotizacion.Venta = cot.Venta;
                        Cotizacion.Exonerar = cot.Exonerar;
                        Cotizacion.Confirmada = cot.Confirmada;
                        Cotizacion.ConfirmadaPor = cot.ConfirmadaPor;
                        Cotizacion.EstadoActual = cot.EstadoActual;
                        Cotizacion.ObservacionEstado = cot.ObservacionEstado;
                        Cotizacion.Telefono = cot.Telefono;
                        Cotizacion.TipoCedula = cot.TipoCedula;
                        Cotizacion.CedulaCliente = cot.CedulaCliente;

                    var ac = from x in entities.CotizacionDetalles
                             where x.Cotizacion == id && !(from t in cot.CotizacionDetalles select t.Numero).Contains(x.Numero)
                             select x;
                    List<Models.CotizacionDetalle> CotizacionesDetalle = ac.ToList<Models.CotizacionDetalle>();

                    foreach (Models.CotizacionDetalle item in CotizacionesDetalle)
                    {
                        var p = entities.CotizacionDetalles.Find(item.Numero);
                        entities.Remove(p);
                        entities.SaveChanges();
                    }

                    Models.CotizacionDetalle nuevaLinea;
                        foreach (Models.CotizacionDetalle Detalle in cot.CotizacionDetalles)
                        {
                            //Agrega nuevos registros
                            if (Detalle.Numero == 0)
                            {
                                nuevaLinea = new Models.CotizacionDetalle();
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
                                nuevaLinea.SubFamilia = Detalle.SubFamilia;
                                nuevaLinea.MaxDescuento = Detalle.MaxDescuento;
                                nuevaLinea.TipoCambioValorCompra = Detalle.TipoCambioValorCompra;
                                nuevaLinea.CodMonedaVenta = Detalle.CodMonedaVenta;
                                Cotizacion.CotizacionDetalles.Add(nuevaLinea);
                            }
                            else
                            {
                                //Actualiza los detalles
                                var a = entities.CotizacionDetalles.Find(Detalle.Numero);
                                Models.CotizacionDetalle lineaModificada = a;
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
                                    lineaModificada.SubFamilia = Detalle.SubFamilia;
                                    lineaModificada.MaxDescuento = Detalle.MaxDescuento;
                                    lineaModificada.TipoCambioValorCompra = Detalle.TipoCambioValorCompra;
                                    lineaModificada.CodMonedaVenta = Detalle.CodMonedaVenta;
                                   
                                    entities.Entry(lineaModificada).State = EntityState.Modified;
                                    entities.SaveChanges();
                                }
                            }

                        }


                    entities.Entry(Cotizacion).State = EntityState.Modified;
                        return entities.SaveChanges();//actualizar Cotizacion

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

        public int Anular(long id)
        {
            try
            {
                var p = entities.Cotizacions.Find(id);
                Models.Cotizacion cotizacion = p;

                if (cotizacion != null)
                {

                    cotizacion.Anulado = true;
                    entities.Entry(cotizacion).State = EntityState.Modified;

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
