using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
   public class ArqueosCajas
    {
        SeePOSContext entities;

        public ArqueosCajas()
        {
            entities = new SeePOSContext();
        }

        public int CrearArqueosCajas(ArqueoCaja caja)
        {
            try
            {
                entities.ArqueoCajas.Add(caja);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int AnuarArqueosCajas(long id)


        {
            try
            {
                var p = entities.ArqueoCajas.Find(id);
                ArqueoCaja Nuevo = p;
                Nuevo.Anulado = true;

                entities.Entry(Nuevo).State = EntityState.Modified;

                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<ArqueoDeposito> ObtenerArqueosDeposito(decimal Id)
        {
            try
            {
                List<ArqueoDeposito> result;
                    var temp = from c in entities.ArqueoDepositos
                               where c.IdApertura == Id
                               select c;
                    result = temp.ToList<ArqueoDeposito>();


                return result;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ArqueoEfectivo> ObtenerArqueosEfectivo(decimal Id)
        {
            try
            {
                List<ArqueoEfectivo> result;
                var temp = from c in entities.ArqueoEfectivos
                           where c.IdArqueo == Id
                           select c;
                result = temp.ToList<ArqueoEfectivo>();

                return result;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ArqueoTarjetum> ObtenerArqueosTarjeta(decimal Id)
        {
            try
            {
                List<ArqueoTarjetum> result;
                var temp = from c in entities.ArqueoTarjeta
                           where c.IdArqueo == Id
                           select c;
                result = temp.ToList<ArqueoTarjetum>();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ArqueoCaja> ObtenerArqueosCajas(bool porId, string Filtro)
        {
            try
            {
                List<ArqueoCaja> result;

                if (porId == true)
                {
                    var temp = from c in entities.ArqueoCajas
                               where c.Id == Convert.ToInt64(Filtro)
                               select c;
                    result = temp.ToList<ArqueoCaja>();
                }
                else
                {
                    // Ojo tomar en cuenta el estado de la caja.
                    // puede que quiera todos los arqueos o que solo quiera los que estan sin cerrar.
                    var temp = from c in entities.ArqueoCajas
                               join a in entities.Aperturacajas on c.IdApertura equals a.Napertura
                               where a.Nombre.Contains(Filtro) 
                               orderby c.Fecha descending
                               select c;
                    result = temp.ToList<ArqueoCaja>();
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


        public int EditarArqueosCajas(long id, ArqueoCaja Arqueo)
        {
            try
            {

                var p = entities.ArqueoCajas.Find(id);
                ArqueoCaja ArqueoCaja = p;
                //ArqueoCaja.Id = Arqueo.Id;
                ArqueoCaja.EfectivoColones = Arqueo.EfectivoColones;
                ArqueoCaja.EfectivoDolares = Arqueo.EfectivoDolares;
                ArqueoCaja.TarjetaColones = Arqueo.TarjetaColones;
                ArqueoCaja.TarjetaDolares = Arqueo.TarjetaDolares;
                ArqueoCaja.Cheques = Arqueo.Cheques;
                ArqueoCaja.ChequesDol = Arqueo.ChequesDol;
                ArqueoCaja.DepositoCol = Arqueo.DepositoCol;
                ArqueoCaja.DepositoDol = Arqueo.DepositoDol;
                ArqueoCaja.Total = Arqueo.Total;
                ArqueoCaja.IdApertura = Arqueo.IdApertura;
                ArqueoCaja.Fecha = Arqueo.Fecha;
                ArqueoCaja.Cajero = Arqueo.Cajero;
                ArqueoCaja.Anulado = Arqueo.Anulado;
                ArqueoCaja.TipoCambioD = Arqueo.TipoCambioD;
                ArqueoCaja.Observaciones = Arqueo.Observaciones;
                ArqueoCaja.TarjetaSistema = Arqueo.TarjetaSistema;
                ArqueoCaja.OtrasTarjetas = Arqueo.OtrasTarjetas;

                var ac1 = from x in entities.ArqueoDepositos
                          where x.IdArqueo == id && !(from t in Arqueo.ArqueoDepositos select t.Id).Contains(x.Id)
                          select x;
                List<Models.ArqueoDeposito> Eliminar1 = ac1.ToList<Models.ArqueoDeposito>();
                foreach (Models.ArqueoDeposito item in Eliminar1)
                {
                    var del = entities.ArqueoDepositos.Find(item.Id);
                    entities.Remove(del);
                    entities.SaveChanges();
                }

                var ac2 = from x in entities.ArqueoEfectivos
                          where x.IdArqueo == id && !(from t in Arqueo.ArqueoEfectivos select t.Id).Contains(x.Id)
                          select x;
                List<Models.ArqueoEfectivo> Eliminar2 = ac2.ToList<Models.ArqueoEfectivo>();
                foreach (Models.ArqueoEfectivo item in Eliminar2)
                {
                    var del = entities.ArqueoEfectivos.Find(item.Id);
                    entities.Remove(del);
                    entities.SaveChanges();
                }

                var ac3 = from x in entities.ArqueoTarjeta
                          where x.IdArqueo == id && !(from t in Arqueo.ArqueoTarjeta select t.Id).Contains(x.Id)
                          select x;
                List<Models.ArqueoTarjetum> Eliminar3 = ac3.ToList<Models.ArqueoTarjetum>();
                foreach (Models.ArqueoTarjetum item in Eliminar3)
                {
                    var del = entities.ArqueoTarjeta.Find(item.Id);
                    entities.Remove(del);
                    entities.SaveChanges();
                }



                Models.ArqueoDeposito nuevaLinea1;
                foreach (Models.ArqueoDeposito Detalle in Arqueo.ArqueoDepositos)
                {
                    //Agrega nuevos registros
                    if (Detalle.Id == 0)
                    {
                        nuevaLinea1 = new Models.ArqueoDeposito();
                        nuevaLinea1.Banco = Detalle.Banco;
                        nuevaLinea1.Cuenta = Detalle.Cuenta;
                        nuevaLinea1.Moneda = Detalle.Moneda;
                        nuevaLinea1.Numero = Detalle.Numero;
                        nuevaLinea1.Monto = Detalle.Monto;
                        nuevaLinea1.IdApertura = Detalle.IdApertura;
                        nuevaLinea1.Tipo = Detalle.Tipo;
                        ArqueoCaja.ArqueoDepositos.Add(nuevaLinea1);
                    }
                    else
                    {
                        //Actualiza los detalles
                        var a = entities.ArqueoDepositos.Find(Detalle.Id);
                        Models.ArqueoDeposito lineaModificada = a;
                        if (lineaModificada != null)
                        {
                            lineaModificada.Banco = Detalle.Banco;
                            lineaModificada.Cuenta = Detalle.Cuenta;
                            lineaModificada.Moneda = Detalle.Moneda;
                            lineaModificada.Numero = Detalle.Numero;
                            lineaModificada.Monto = Detalle.Monto;
                            lineaModificada.IdApertura = Detalle.IdApertura;
                            lineaModificada.Tipo = Detalle.Tipo;

                            entities.Entry(lineaModificada).State = EntityState.Modified;
                            entities.SaveChanges();
                        }
                    }

                }

                Models.ArqueoEfectivo nuevaLinea2;
                foreach (Models.ArqueoEfectivo Detalle in Arqueo.ArqueoEfectivos)
                {
                    //Agrega nuevos registros
                    if (Detalle.Id == 0)
                    {
                        nuevaLinea2 = new Models.ArqueoEfectivo();
                        nuevaLinea2.IdDenominacion = Detalle.IdDenominacion;
                        nuevaLinea2.Monto = Detalle.Monto;
                        nuevaLinea2.Cantidad = Detalle.Cantidad;

                        ArqueoCaja.ArqueoEfectivos.Add(nuevaLinea2);
                    }
                    else
                    {
                        //Actualiza los detalles
                        var a = entities.ArqueoEfectivos.Find(Detalle.Id);
                        Models.ArqueoEfectivo lineaModificada = a;
                        if (lineaModificada != null)
                        {
                            lineaModificada.IdDenominacion = Detalle.IdDenominacion;
                            lineaModificada.Monto = Detalle.Monto;
                            lineaModificada.Cantidad = Detalle.Cantidad;

                            entities.Entry(lineaModificada).State = EntityState.Modified;
                            entities.SaveChanges();
                        }
                    }

                }

                Models.ArqueoTarjetum nuevaLinea3;
                foreach (Models.ArqueoTarjetum Detalle in Arqueo.ArqueoTarjeta)
                {
                    //Agrega nuevos registros
                    if (Detalle.Id == 0)
                    {
                        nuevaLinea3 = new Models.ArqueoTarjetum();
                        nuevaLinea3.IdTarjeta = Detalle.IdTarjeta;
                        nuevaLinea3.Monto = Detalle.Monto;
                        ArqueoCaja.ArqueoTarjeta.Add(nuevaLinea3);
                    }
                    else
                    {
                        //Actualiza los detalles
                        var a = entities.ArqueoTarjeta.Find(Detalle.Id);
                        Models.ArqueoTarjetum lineaModificada = a;
                        if (lineaModificada != null)
                        {
                            lineaModificada.IdTarjeta = Detalle.IdTarjeta;
                            lineaModificada.Monto = Detalle.Monto;

                            entities.Entry(lineaModificada).State = EntityState.Modified;
                            entities.SaveChanges();
                        }
                    }

                }

                entities.Entry(ArqueoCaja).State = EntityState.Modified;
                return entities.SaveChanges();


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
