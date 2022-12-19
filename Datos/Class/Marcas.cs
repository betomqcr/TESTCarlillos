using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;


namespace Datos.Class
{
   public class Marcas
    {

        private SeePOSContext entities;

        public Marcas()
        {
            entities = new SeePOSContext();
        }

        public int Crear(Models.Marca marca) // crear carta apartir de objeto de creacion
        {
            try
            {
                entities.Marcas.Add(marca);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Models.Marca> Buscar(bool porNombre, string filtro) //obtener lista CartasdeExoneracion 
        {
            try
            {
                List<Models.Marca> result;

                if (porNombre == true)
                {
                    //busca por la descripcion de la marca
                    var temp = from c in entities.Marcas
                               where c.Marca1.Contains(filtro)// usar un like
                               orderby c.Marca1
                               select c;

                    result = temp.ToList<Models.Marca>();
                }
                else
                {
                    //busca por el id de la tabla
                    var temp = from c in entities.Marcas
                               where c.CodMarca == Convert.ToInt32(filtro) //convertir el datos de string a long
                               select c;
                    result = temp.ToList<Models.Marca>();
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

        public int Editar(int id, Models.Marca marca)
        {
            try
            {
                var p = entities.Marcas.Find(id);
                Models.Marca viejo = p;

                if (viejo != null)
                {
                    viejo.Marca1 = marca.Marca1;

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
                var p = entities.Marcas.Find(id);               
                Models.Marca Nuevo = p;
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
