using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
    public class DescuentoProgramados
    {


        private SeePOSContext entities;

        public DescuentoProgramados()
        {
            entities = new SeePOSContext();
        }

        public int Crear(Models.DescuentoProgramado descuentos) // crear carta apartir de objeto de creacion
        {
            try
            {
                entities.DescuentoProgramados.Add(descuentos);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Models.DescuentoProgramado> ObtenerporId(decimal id)  
        {
            try
            {
                List<Models.DescuentoProgramado> result;

                    //busca por el id de la tabla
                    var temp = from c in entities.DescuentoProgramados
                               where c.Id == id //convertir el datos de string a long
                               select c;
                    result = temp.ToList<Models.DescuentoProgramado>();
                

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

        public int Editar(long id, Models.DescuentoProgramado nuevo)
        {
            try
            {
                var p = entities.DescuentoProgramados.Find(id);
                Models.DescuentoProgramado viejo = p;

                if (viejo != null)
                {

                    viejo.CodProveedor = nuevo.CodProveedor;
                    viejo.Porcentaje = nuevo.Porcentaje;

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

        public int Borrar(decimal id) // borrar Actividad apartir del id Actividad


        {
            try
            {
                var p = entities.DescuentoProgramados.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


    }
}
