using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
    public class DenominacionMoneda
    {

        private SeePOSContext entities;

        public DenominacionMoneda()
        {
            entities = new SeePOSContext();
        }

        public int Crear(Models.DenominacionMonedum denominacion) // crear carta apartir de objeto de creacion
        {
            try
            {
                entities.DenominacionMoneda.Add(denominacion);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<Models.DenominacionMonedum> Buscar(bool porNombre, string filtro) //obtener lista CartasdeExoneracion 
        {
            try
            {
                List<Models.DenominacionMonedum> result;

                if (porNombre == true)
                {
                    //busca por la descripcion
                    var temp = from c in entities.DenominacionMoneda
                               where c.Denominacion.ToString().Contains(filtro) // usar un like                               
                               select c;

                    result = temp.ToList<Models.DenominacionMonedum>();
                }
                else
                {
                    //busca por el id de la tabla
                    var temp = from c in entities.DenominacionMoneda
                               where c.Id == Convert.ToInt64(filtro) //convertir el datos de string a long
                               select c;
                    result = temp.ToList<Models.DenominacionMonedum>();
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

        public int Editar(long id, Models.DenominacionMonedum nuevo)
        {
            try
            {
                var p = entities.DenominacionMoneda.Find(id);
                Models.DenominacionMonedum viejo = p;

                if (viejo != null)
                {

                    viejo.CodMoneda = nuevo.CodMoneda;
                    viejo.Denominacion = nuevo.Denominacion;
                    viejo.Tipo = nuevo.Tipo;

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

        public int Borrar(long id) // borrar Actividad apartir del id Actividad
        {
            try
            {
                var p = entities.DenominacionMoneda.Find(id);                                
                Models.DenominacionMonedum Nuevo = p;
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
