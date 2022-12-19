using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
   public class Areas
    {
        SeePOSContext entities;

        public Areas()
        {
            entities = new SeePOSContext();
        }

        public int CrearAreas(Area area)
        {
            try
            {
                entities.Areas.Add(area);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int BorrarAreas(int id)
        {
            try
            {
                var p = entities.Areas.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }



        public List<AreaArticulo> ObtenerAreasArticulo(Decimal Id)
        {
            try
            {
                List<AreaArticulo> result;               
                    var temp = from c in entities.AreaArticulos
                               where c.IdArea == Id
                               select c;
                    result = temp.ToList<AreaArticulo>();
                

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

        public List<AreaEncargado> ObtenerAreasEncargado(Decimal Id)
        {
            try
            {
                List<AreaEncargado> result;
                var temp = from c in entities.AreaEncargados
                           where c.IdArea == Id
                           select c;
                result = temp.ToList<AreaEncargado>();


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

        public List<Area> ObtenerAreas(bool porId, string Filtro)
        {
            try
            {
                List<Area> result;

                if (porId == true)
                {
                    var temp = from c in entities.Areas
                               where c.IdArea == Convert.ToInt64(Filtro)
                               select c;
                    result = temp.ToList<Area>();
                }
                else
                {
                    var temp = from c in entities.Areas
                               where c.Descripcion.Contains(Filtro)
                               orderby c.Descripcion ascending
                               select c;
                    result = temp.ToList<Area>();
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

        public int EditarAreas(int id, Area area)
        {
            try
            {
                var p = entities.Areas.Find(id);
                Area Nuevo = p;                
                if (Nuevo != null)
                {
                    Nuevo.IdSucursal = area.IdSucursal;
                    Nuevo.Descripcion = area.Descripcion;
                    Nuevo.Observaciones = area.Observaciones;

                    var ac1 = from x in entities.AreaArticulos
                              where x.IdArea == id && !(from t in Nuevo.AreaArticulos select t.IdAreaArticulo).Contains(x.IdAreaArticulo)
                              select x;
                    List<Models.AreaArticulo> Eliminar1 = ac1.ToList<Models.AreaArticulo>();

                    foreach (Models.AreaArticulo item in Eliminar1)
                    {
                        var del = entities.AreaArticulos.Find(item.IdAreaArticulo);
                        entities.Remove(del);
                        entities.SaveChanges();
                    }

                    var ac2 = from x in entities.AreaEncargados
                              where x.IdArea == id && !(from t in Nuevo.AreaEncargados select t.IdAreaEncargado).Contains(x.IdAreaEncargado)
                              select x;
                    List<Models.AreaEncargado> Eliminar2 = ac2.ToList<Models.AreaEncargado>();

                    foreach (Models.AreaEncargado item in Eliminar2)
                    {
                        var del = entities.AreaEncargados.Find(item.IdAreaEncargado);
                        entities.Remove(del);
                        entities.SaveChanges();
                    }


                    Models.AreaArticulo nuevaLinea1;
                    foreach (Models.AreaArticulo Detalle in Nuevo.AreaArticulos)
                    {
                        //Agrega nuevos registros
                        if (Detalle.IdAreaArticulo == 0)
                        {
                            nuevaLinea1 = new Models.AreaArticulo();
                            nuevaLinea1.IdArea = Detalle.IdArea;
                            nuevaLinea1.Codigo = Detalle.Codigo;
                            Nuevo.AreaArticulos.Add(nuevaLinea1);
                        }
                        else
                        {
                            //Actualiza los detalles
                            var a = entities.AreaArticulos.Find(Detalle.IdAreaArticulo);
                            Models.AreaArticulo lineaModificada = a;
                            if (lineaModificada != null)
                            {
                                lineaModificada.IdArea = Detalle.IdArea;
                                lineaModificada.Codigo = Detalle.Codigo;

                                entities.Entry(lineaModificada).State = EntityState.Modified;
                                entities.SaveChanges();
                            }
                        }

                    }

                    Models.AreaEncargado nuevaLinea2;
                    foreach (Models.AreaEncargado Detalle in Nuevo.AreaEncargados)
                    {
                        //Agrega nuevos registros
                        if (Detalle.IdAreaEncargado == 0)
                        {
                            nuevaLinea2 = new Models.AreaEncargado();
                            nuevaLinea2.IdArea = Detalle.IdArea;
                            nuevaLinea2.IdUsuario = Detalle.IdUsuario;
                            Nuevo.AreaEncargados.Add(nuevaLinea2);
                        }
                        else
                        {
                            //Actualiza los detalles
                            var a = entities.AreaEncargados.Find(Detalle.IdAreaEncargado);
                            Models.AreaEncargado lineaModificada = a;
                            if (lineaModificada != null)
                            {
                                lineaModificada.IdArea = Detalle.IdArea;
                                lineaModificada.IdUsuario = Detalle.IdUsuario;

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
