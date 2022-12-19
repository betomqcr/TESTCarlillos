using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
    public class devolucion_prestamo
    {

        private SeePOSContext entities;

        public devolucion_prestamo()
        {
            entities = new SeePOSContext();
        }

        public int Crear(Models.DevolucionPrestamo devPrestamo) 
        {
            try
            {
                entities.DevolucionPrestamos.Add(devPrestamo);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //public List<Models.ArticulosComprasDevuelto> BuscarDetalle(long Id)
        //{
        //    try
        //    {
        //        List<Models.ArticulosComprasDevuelto> result;
              
        //            var temp = from c in entities.ArticulosComprasDevueltos
        //                       where c.Devolucion == Id
        //                       select c;
        //            result = temp.ToList<Models.ArticulosComprasDevuelto>();
                

        //        if (result.Count > 0)
        //        {
        //            return result;
        //        }
        //        else
        //        {
        //            return result = null;
        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public List<Models.DevolucionPrestamo> Buscar(bool porNombre, string filtro)  
        {
            try
            {
                List<Models.DevolucionPrestamo> result;

                if (porNombre == true)
                {
                    //busca por la descripcion
                    var temp = from c in entities.DevolucionPrestamos
                               where c.Descripcion.Contains(filtro) // usar un like                               
                               orderby c.Fecha descending
                               select c;

                    result = temp.ToList<Models.DevolucionPrestamo>();
                }
                else
                {
                    //busca por el id de la tabla
                    var temp = from c in entities.DevolucionPrestamos
                               where c.IdPrestamo == Convert.ToInt64(filtro) //convertir el datos de string a long
                               select c;
                    result = temp.ToList<Models.DevolucionPrestamo>();
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

        public int Borrar(int id) // borrar Devolucion de prestamo
        {
            try
            {
                var p = entities.DevolucionPrestamos.Find(id);
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
