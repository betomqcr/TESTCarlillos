using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
  public  class Compras
    {

        SeePOSContext entities;

        public Compras()
        {
            entities = new SeePOSContext();
        }


        public int CrearCompras(Models.Compra compra)
        {
            try
            {
                entities.Compras.Add(compra);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int BorrarCompra(long id)
        {
            try
            {
                var p = entities.Compras.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Models.ArticulosComprado> ObtenerArticulosComprados(long IdCompra)
        {
            try
            {
                List<Models.ArticulosComprado> result;
                    var temp = from c in entities.ArticulosComprados
                               where c.IdCompra == IdCompra
                               select c;
                    result = temp.ToList<Models.ArticulosComprado>();

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

        public List<Models.Compra> ObtenerCompras(bool porId, string Filtro)
        {
            try

            {
                List<Models.Compra> result;

                if (porId == true)
                {
                    var temp = from c in entities.Compras
                               where c.IdCompra == Convert.ToInt64(Filtro)
                               select c;
                    result = temp.ToList<Models.Compra>();
                }
                else
                {
                    var temp = from c in entities.Compras
                               join p in entities.Proveedores on c.CodigoProv equals p.CodigoProv
                              where p.Nombre.Contains(Filtro) && c.Gasto == false
                              orderby c.Fecha descending
                               select c;
                    result = temp.ToList<Models.Compra>();
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

        public int EditarCompras(long id, Models.Compra compra)
        {
            try
            {

                var c = entities.Compras.Find(id);
                Compra nuevacompra = c;
                nuevacompra.Factura = compra.Factura;
                nuevacompra.CodigoProv = compra.CodigoProv;
                nuevacompra.SubTotalGravado = compra.SubTotalGravado;
                nuevacompra.SubTotalExento = compra.SubTotalExento;
                nuevacompra.Descuento = compra.Descuento;
                nuevacompra.Impuesto = compra.Impuesto;
                nuevacompra.TotalFactura = compra.TotalFactura;
                nuevacompra.Fecha = compra.Fecha;
                nuevacompra.Vence = compra.Vence;
                nuevacompra.FechaIngreso = compra.FechaIngreso;
                nuevacompra.MotivoGasto = compra.MotivoGasto;
                nuevacompra.Compra1 = compra.Compra1;
                nuevacompra.Contabilizado = compra.Contabilizado;
                nuevacompra.Consignacion = compra.Consignacion;
                nuevacompra.Asiento = compra.Asiento;
                nuevacompra.ContaInve = compra.ContaInve;
                nuevacompra.AsientoInve = compra.AsientoInve;
                nuevacompra.TipoCompra = compra.TipoCompra;
                nuevacompra.CedulaUsuario = compra.CedulaUsuario;
                nuevacompra.CodMonedaCompra = compra.CodMonedaCompra;
                nuevacompra.FacturaCancelado = compra.FacturaCancelado;
                nuevacompra.Gasto = compra.Gasto;
                nuevacompra.TipoCambio = compra.TipoCambio;
                nuevacompra.CambioImpuesto = compra.CambioImpuesto;
                nuevacompra.Taller = compra.Taller;
                nuevacompra.Mascotas = compra.Mascotas;
                nuevacompra.NumOrden = compra.NumOrden;
                nuevacompra.Fec = compra.Fec;
                nuevacompra.CodigoActividad = compra.CodigoActividad;
                nuevacompra.EnviadoDgt = compra.EnviadoDgt;
                nuevacompra.EstadoDgt = compra.EstadoDgt;
                nuevacompra.ConsecutivoDgt = compra.ConsecutivoDgt;
                nuevacompra.ClaveDgt = compra.ClaveDgt;
                nuevacompra.Trans = compra.Trans;
                nuevacompra.NumTrans = compra.NumTrans;
                nuevacompra.Prepagada = compra.Prepagada;
                nuevacompra.PreAbono = compra.PreAbono;


                var ac = from x in entities.ArticulosComprados
                         where x.IdCompra == id && !(from t in compra.ArticulosComprados select t.IdArticuloComprados).Contains(x.IdArticuloComprados)
                         select x;
                List<Models.ArticulosComprado> Eliminar = ac.ToList<Models.ArticulosComprado>();

                foreach (Models.ArticulosComprado item in Eliminar)
                {
                    var p = entities.ArticulosComprados.Find(item.IdArticuloComprados);
                    entities.Remove(p);
                    entities.SaveChanges();
                }

                Models.ArticulosComprado nuevaLinea;
                foreach (Models.ArticulosComprado Detalle in compra.ArticulosComprados)
                {
                    //Agrega nuevos registros
                    if (Detalle.IdArticuloComprados == 0)
                    {
                        nuevaLinea = new Models.ArticulosComprado();
                        nuevaLinea.Codigo = Detalle.Codigo;
                        nuevaLinea.CodArticulo = Detalle.CodArticulo;
                        nuevaLinea.Descripcion = Detalle.Descripcion;
                        nuevaLinea.Base = Detalle.Base;
                        nuevaLinea.MontoFlete = Detalle.MontoFlete;
                        nuevaLinea.OtrosCargos = Detalle.OtrosCargos;
                        nuevaLinea.Costo = Detalle.Costo;
                        nuevaLinea.Cantidad = Detalle.Cantidad;
                        nuevaLinea.Regalias = Detalle.Regalias;
                        nuevaLinea.Gravado = Detalle.Gravado;
                        nuevaLinea.Exento = Detalle.Exento;
                        nuevaLinea.DescuentoP = Detalle.DescuentoP;
                        nuevaLinea.Descuento = Detalle.Descuento;
                        nuevaLinea.ImpuestoP = Detalle.ImpuestoP;
                        nuevaLinea.Impuesto = Detalle.Impuesto;
                        nuevaLinea.Total = Detalle.Total;
                        nuevaLinea.Devoluciones = Detalle.Devoluciones;
                        nuevaLinea.PrecioA = Detalle.PrecioA;
                        nuevaLinea.PrecioB = Detalle.PrecioB;
                        nuevaLinea.PrecioC = Detalle.PrecioC;
                        nuevaLinea.PrecioD = Detalle.PrecioD;
                        nuevaLinea.CodMonedaVenta = Detalle.CodMonedaVenta;
                        nuevaLinea.NuevoCostoBase = Detalle.NuevoCostoBase;
                        nuevaLinea.Lote = Detalle.Lote;
                        nuevaLinea.Bonificado = Detalle.Bonificado;
                        nuevaLinea.CodigoBonificado = Detalle.CodigoBonificado;
                        nuevaLinea.CantidadBonificado = Detalle.CantidadBonificado;
                        nuevaLinea.CostoBonificado = Detalle.CostoBonificado;
                        nuevaLinea.SubTotalBonificado = Detalle.SubTotalBonificado;
                        nuevaLinea.CodArticuloBonificacion = Detalle.CodArticuloBonificacion;
                        nuevaLinea.CodCabys = Detalle.CodCabys;
                        nuevacompra.ArticulosComprados.Add(nuevaLinea);
                    }
                    else
                    {
                        //Actualiza los detalles
                        var a = entities.ArticulosComprados.Find(Detalle.IdArticuloComprados);
                        Models.ArticulosComprado lineaModificada = a;
                        if (lineaModificada != null)
                        {
                            lineaModificada.Codigo = Detalle.Codigo;
                            lineaModificada.CodArticulo = Detalle.CodArticulo;
                            lineaModificada.Descripcion = Detalle.Descripcion;
                            lineaModificada.Base = Detalle.Base;
                            lineaModificada.MontoFlete = Detalle.MontoFlete;
                            lineaModificada.OtrosCargos = Detalle.OtrosCargos;
                            lineaModificada.Costo = Detalle.Costo;
                            lineaModificada.Cantidad = Detalle.Cantidad;
                            lineaModificada.Regalias = Detalle.Regalias;
                            lineaModificada.Gravado = Detalle.Gravado;
                            lineaModificada.Exento = Detalle.Exento;
                            lineaModificada.DescuentoP = Detalle.DescuentoP;
                            lineaModificada.Descuento = Detalle.Descuento;
                            lineaModificada.ImpuestoP = Detalle.ImpuestoP;
                            lineaModificada.Impuesto = Detalle.Impuesto;
                            lineaModificada.Total = Detalle.Total;
                            lineaModificada.Devoluciones = Detalle.Devoluciones;
                            lineaModificada.PrecioA = Detalle.PrecioA;
                            lineaModificada.PrecioB = Detalle.PrecioB;
                            lineaModificada.PrecioC = Detalle.PrecioC;
                            lineaModificada.PrecioD = Detalle.PrecioD;
                            lineaModificada.CodMonedaVenta = Detalle.CodMonedaVenta;
                            lineaModificada.NuevoCostoBase = Detalle.NuevoCostoBase;
                            lineaModificada.Lote = Detalle.Lote;
                            lineaModificada.Bonificado = Detalle.Bonificado;
                            lineaModificada.CodigoBonificado = Detalle.CodigoBonificado;
                            lineaModificada.CantidadBonificado = Detalle.CantidadBonificado;
                            lineaModificada.CostoBonificado = Detalle.CostoBonificado;
                            lineaModificada.SubTotalBonificado = Detalle.SubTotalBonificado;
                            lineaModificada.CodArticuloBonificacion = Detalle.CodArticuloBonificacion;
                            lineaModificada.CodCabys = Detalle.CodCabys;

                            entities.Entry(lineaModificada).State = EntityState.Modified;
                            entities.SaveChanges();
                        }
                    }

                }
                entities.Entry(nuevacompra).State = EntityState.Modified;

                return entities.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
