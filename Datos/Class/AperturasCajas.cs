using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
    public class AperturasCajas
    {
        SeePOSContext entities;

        public AperturasCajas()
        {
            entities = new SeePOSContext();
        }

        public int CrearAperturasCajas(Aperturacaja apertura)
        {
            try
            {
                entities.Aperturacajas.Add(apertura);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int AnularAperturasCajas(int id)
        {
            try
            {
                var p = entities.Aperturacajas.Find(id);
                Aperturacaja Nuevo = p;                
                Nuevo.Anulado = true;            

                entities.Entry(Nuevo).State = EntityState.Modified;

                return entities.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<AperturaDenominacione> ObtenerAperturaDenominaciones(long NApertura)
        {
            try
            {

                List<AperturaDenominacione> result;

                
                    var temp = from c in entities.AperturaDenominaciones
                               where c.IdApertura == NApertura
                               select c;
                    result = temp.ToList<AperturaDenominacione>();                              

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

        public List<AperturaTotalTope> ObtenerAperturaTope(long NApertura)
        {
            try
            {

                List<AperturaTotalTope> result;

                var temp = from c in entities.AperturaTotalTopes
                           where c.Napertura == NApertura
                           select c;
                result = temp.ToList<AperturaTotalTope>();

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

        public List<Aperturacaja> ObtenerAperturasCajas(bool porId, string Filtro)
        {
            try
            {

                List<Aperturacaja> result;

                if (porId == true)
                {
                    var temp = from c in entities.Aperturacajas
                               where c.Napertura == Convert.ToInt64(Filtro)
                               select c;
                    result = temp.ToList<Aperturacaja>();
                }
                else
                {
                    var temp = from c in entities.Aperturacajas
                               where c.Nombre.Contains(Filtro)
                               orderby c.Fecha descending
                               select c;
                    result = temp.ToList<Aperturacaja>();
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

        public int EditarAperturasCajas(int id, Aperturacaja aperturacaja)
        {
            try
            {
                var p = entities.Aperturacajas.Find(id);
                Aperturacaja Nuevo = p;
                if (Nuevo != null)
                {
                    //Nuevo.Napertura = aperturacaja.Napertura;
                    Nuevo.Fecha = aperturacaja.Fecha;
                    Nuevo.Nombre = aperturacaja.Nombre;
                    Nuevo.Estado = aperturacaja.Estado;
                    Nuevo.Observaciones = aperturacaja.Observaciones;
                    Nuevo.Anulado = aperturacaja.Anulado;
                    Nuevo.Cedula = aperturacaja.Cedula;
                    Nuevo.NumCaja = aperturacaja.NumCaja;
                    Nuevo.IdSucursal = aperturacaja.IdSucursal;

                    var ac1 = from x in entities.AperturaDenominaciones
                             where x.IdApertura == id && !(from t in aperturacaja.AperturaDenominaciones select t.Id).Contains(x.Id)
                             select x;
                    List<Models.AperturaDenominacione> Eliminar1 = ac1.ToList<Models.AperturaDenominacione>();

                    foreach (Models.AperturaDenominacione item in Eliminar1)
                    {
                        var del = entities.AperturaDenominaciones.Find(item.Id);
                        entities.Remove(del);
                        entities.SaveChanges();
                    }

                    var ac2 = from x in entities.AperturaTotalTopes
                              where x.Napertura == id && !(from t in aperturacaja.AperturaTotalTopes select t.IdTotalTope).Contains(x.IdTotalTope)
                              select x;
                    List<Models.AperturaTotalTope> Eliminar2 = ac2.ToList<Models.AperturaTotalTope>();

                    foreach (Models.AperturaTotalTope item in Eliminar2)
                    {
                        var del = entities.AperturaTotalTopes.Find(item.IdTotalTope);
                        entities.Remove(del);
                        entities.SaveChanges();
                    }

                    Models.AperturaDenominacione AperturaDenominacion;
                    foreach (Models.AperturaDenominacione Detalle in aperturacaja.AperturaDenominaciones)
                    {
                        //Agrega nuevos registros
                        if (Detalle.Id == 0)
                        {
                            AperturaDenominacion = new Models.AperturaDenominacione();
                            AperturaDenominacion.IdApertura = Detalle.IdApertura;
                            AperturaDenominacion.IdDenominacion = Detalle.IdDenominacion;
                            AperturaDenominacion.Monto = Detalle.Monto;
                            AperturaDenominacion.Cantidad = Detalle.Cantidad;
                            Nuevo.AperturaDenominaciones.Add(AperturaDenominacion);
                        }
                        else
                        {
                            //Actualiza los detalles
                            var a = entities.AperturaDenominaciones.Find(Detalle.Id);
                            Models.AperturaDenominacione lineaModificada = a;
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

                    Models.AperturaTotalTope AperturaTope;
                    foreach (Models.AperturaTotalTope Detalle in aperturacaja.AperturaTotalTopes)
                    {
                        //Agrega nuevos registros
                        if (Detalle.IdTotalTope == 0)
                        {
                            AperturaTope = new Models.AperturaTotalTope();
                            AperturaTope.Napertura = Detalle.Napertura;
                            AperturaTope.CodMoneda = Detalle.CodMoneda;
                            AperturaTope.MontoTope = Detalle.MontoTope;
                            AperturaTope.MonedaNombre = Detalle.MonedaNombre;
                            Nuevo.AperturaTotalTopes.Add(AperturaTope);
                        }
                        else
                        {
                            //Actualiza los detalles
                            var a = entities.AperturaTotalTopes.Find(Detalle.IdTotalTope);
                            Models.AperturaTotalTope lineaModificada = a;
                            if (lineaModificada != null)
                            {
                                lineaModificada.CodMoneda = Detalle.CodMoneda;
                                lineaModificada.MontoTope = Detalle.MontoTope;
                                lineaModificada.MonedaNombre = Detalle.MonedaNombre;

                                entities.Entry(lineaModificada).State = EntityState.Modified;
                                entities.SaveChanges();
                            }
                        }

                    }

                    entities.Entry(Nuevo).State = EntityState.Modified;
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
