using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
  public  class CambioInventario
    {

        SeePOSContext entities;

        public CambioInventario()
        {
            entities = new SeePOSContext();
        }

        public int CrearCambioInventario(Models.CambioInventario area)
        {
            try
            {
                entities.CambioInventarios.Add(area);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int BorrarCambioInventario(int id)
        {
            try
            {                
                var p = entities.CambioInventarios.Find(id);
                Models.CambioInventario Nuevo = p;
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

        public List<Models.CambioInventario> ObtenerCambioInventarioSinAplicar()
        {
            try
            {
                List<Models.CambioInventario> result;
         
                    var temp = from c in entities.CambioInventarios
                               where c.Aplicado == false
                               select c;
                    result = temp.ToList<Models.CambioInventario>();
               
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


        //Ojo pendiente el metodo AplicarCambioInventario
        // es una llamada a un procedimiento almacenado.


    }
}
