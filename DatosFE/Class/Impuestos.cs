using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosFE.Models;

namespace DatosFE.Class
{
    public class Impuestos
    {
        private FEContext entities;

        public Impuestos()
        {
            entities = new FEContext();
        }

        public int CrearImpuestos(Impuesto impuesto) // crear impuestos apartir de objeto de creacion
        {
            try
            {
                entities.Impuestos.Add(impuesto);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int BorrarImpuestos(int id) // borrar impuestos apartir del id Actividad


        {
            try
            {
                var p = entities.Impuestos.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Impuesto> ObtenerImpuestos() //obtener lista Impuestos
        {
            try
            {
                var temp = from c in entities.Impuestos
                           where c.Inactivo == false
                           select c;
                List<Impuesto> result = temp.ToList<Impuesto>();

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
