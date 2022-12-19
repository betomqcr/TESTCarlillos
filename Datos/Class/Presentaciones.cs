using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
  public  class Presentaciones
    {

        private SeePOSContext entities;

        public Presentaciones()
        {
            entities = new SeePOSContext();
        }

        public int Crear(Models.Presentacione presentacion) // crear carta apartir de objeto de creacion
        {
            try
            {
                entities.Presentaciones.Add(presentacion);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Models.Presentacione> Buscar(bool porNombre, string filtro) //obtener lista CartasdeExoneracion 
        {
            try
            {
                List<Models.Presentacione> result;

                if (porNombre == true)
                {
                    //busca por la descripcion de la marca
                    var temp = from c in entities.Presentaciones
                               where c.Presentaciones.Contains(filtro)// usar un like
                               orderby c.Presentaciones
                               select c;

                    result = temp.ToList<Models.Presentacione>();
                }
                else
                {
                    //busca por el id de la tabla
                    var temp = from c in entities.Presentaciones
                               where c.CodPres == Convert.ToInt32(filtro) //convertir el datos de string a long
                               select c;
                    result = temp.ToList<Models.Presentacione>();
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

        public int Editar(int id, Models.Presentacione presentaciones)
        {
            try
            {
                var p = entities.Presentaciones.Find(id);
                Models.Presentacione viejo = p;

                if (viejo != null)
                {
                    viejo.Presentaciones = presentaciones.Presentaciones;
                    viejo.Mh = presentaciones.Mh;

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

        public int Borrar(int id) // borrar Actividad apartir del id Actividad


        {
            try
            {
                var p = entities.Presentaciones.Find(id);
                Models.Presentacione Nuevo = p;
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
