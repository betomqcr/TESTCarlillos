using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosFE.Models;

namespace DatosFE.Class
{
    public class Ubicaciones
    {
        private FEContext entities;

        public Ubicaciones()
        {
            entities = new FEContext();
        }

        public int CrearUbicacion(Ubicacion ubicacion) // crear Ubicacion apartir de objeto de creacion
        {
            try
            {
                entities.Ubicacions.Add(ubicacion);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int BorrarUbicacion(int id) // borrar Ubicacion apartir del id Actividad


        {
            try
            {
                var p = entities.Ubicacions.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Ubicacion> ObtenerUbicaciones() //obtener lista actividades 
        {
            try
            {
                var temp = from c in entities.Ubicacions

                           select c;
                List<Ubicacion> result = temp.ToList<Ubicacion>();

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

        public List<Provincia> ObtenerProvincia()
        {
            Ubicaciones ubi = new Ubicaciones();
            try
            {
                List<Provincia> listaP = new List<Provincia>();
                List<Ubicacion> lista = ubi.ObtenerUbicaciones();

                if (lista.Count > 0)
                {
                    foreach (Ubicacion temp in lista)
                    {
                        Provincia x = (from c in listaP
                                where c.id == temp.IdProvincia
                                select c).FirstOrDefault();

                        if (x == null)
                        {
                            Provincia provincia = new Provincia();

                            provincia.id = temp.IdProvincia;
                            provincia.provincia = temp.Provincia;
                            listaP.Add(provincia);
                        }                        
                    }

                    return listaP;

                }
                else
                {
                    return listaP;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }// obtener provincias

        public List<Canton> ObtenerCanton(decimal provincia)
        {
            Ubicaciones ubi = new Ubicaciones();
            try
            {
                List<Canton> listaP = new List<Canton>();
                List<Ubicacion> lista = ubi.ObtenerUbicaciones();

                if (lista.Count > 0)
                {
                    foreach (Ubicacion temp in lista)
                    {
                        if (temp.IdProvincia == provincia)
                        {

                            Canton x = (from c in listaP
                                           where c.id == temp.IdCanton
                                           select c).FirstOrDefault();

                            if (x == null)
                            {
                                Canton canton = new Canton();

                                canton.id = temp.IdCanton;
                                canton.canton = temp.Canton;

                                listaP.Add(canton);
                            }

                               
                        }                        
                    }

                    return listaP;

                }
                else
                {
                    return listaP;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }// obtener Cantones

        public List<Distrito> ObtenerDistrito(decimal canton, decimal provincia )
        {
            Ubicaciones ubi = new Ubicaciones();
            try
            {
                List<Distrito> listaP = new List<Distrito>();
                List<Ubicacion> lista = ubi.ObtenerUbicaciones();

                if (lista.Count > 0)
                {
                    foreach (Ubicacion temp in lista)
                    {

                        if(temp.IdCanton == canton && temp.IdProvincia == provincia)
                        {

                            Distrito x = (from c in listaP
                                        where c.id == temp.IdDistrito
                                        select c).FirstOrDefault();

                            if (x == null)
                            {
                                Distrito Distrito = new Distrito();

                                Distrito.id = temp.IdDistrito;
                                Distrito.provincia = temp.Distrito;

                                listaP.Add(Distrito);
                            }                                
                        }                        
                    }

                    return listaP;

                }
                else
                {
                    return listaP;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }// obtener Distrito

    }
}
