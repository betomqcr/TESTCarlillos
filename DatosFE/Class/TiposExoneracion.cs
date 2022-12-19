using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosFE.Models;

namespace DatosFE.Class
{
    public class TiposExoneracion
    {
        private FEContext entities;

        public TiposExoneracion()
        {
            entities = new FEContext();
        }

        public int CrearTipoExoneracion(TipoExoneracion Tipo) // crear Tipo Exoneracion apartir de objeto de creacion
        {
            try
            {
                entities.TipoExoneracions.Add(Tipo);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int BorrarTipoExoneracion(int id) // borrar TipoExoneracion apartir del id Actividad


        {
            try
            {
                var p = entities.TipoExoneracions.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<TipoExoneracion> ObtenerTiposExoneracion() //obtener lista actividades 
        {
            try
            {
                var temp = from c in entities.TipoExoneracions

                           select c;
                List<TipoExoneracion> result = temp.ToList<TipoExoneracion>();

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
