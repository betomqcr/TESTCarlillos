using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosFE.Models;

namespace DatosFE.Class
{
    public class CondicionImpuestos
    {
        FEContext entities;
        
        public CondicionImpuestos()
        {
            entities = new FEContext();
        }

        public int CrearCondicionImpuesto(CondicionImpuesto impuesto) // crear condicion impuestos apartir de objeto de creacion
        {
            try
            {
                entities.CondicionImpuestos.Add(impuesto);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int BorrarCondicionImpuestos(int id) // borrar condicion impuestos apartir del id Actividad


        {
            try
            {
                var p = entities.CondicionImpuestos.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<CondicionImpuesto> ObtenerCondicionImpuestos() //obtener lista condicion Impuestos
        {
            try
            {
                var temp = from c in entities.CondicionImpuestos

                           select c;
                List<CondicionImpuesto> result = temp.ToList<CondicionImpuesto>();

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
    }
}
