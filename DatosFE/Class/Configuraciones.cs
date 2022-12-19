using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosFE.Models;

namespace DatosFE.Class
{
  public  class Configuraciones
    {
        private FEContext entities;

        public Configuraciones()
        {
            entities = new FEContext();
        }

        public int CrearConfiguracion(Configuracione Conf) // crear Configuraciones apartir de objeto de creacion
        {
            try
            {
                entities.Configuraciones.Add(Conf);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int BorrarConfiguracion(int id) // borrar Configuraciones apartir del id Actividad


        {
            try
            {
                var p = entities.Configuraciones.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Configuracione> ObtenerConfiguraciones(string cedula) //obtener lista actividades 
        {
            try
            {
                if (cedula == "")
                {
                    var temp = from c in entities.Configuraciones

                               select c;
                    List<Configuracione> result = temp.ToList<Configuracione>();

                    if (result.Count > 0)
                    {
                        return result;
                    }
                    else
                    {
                        return result = null;
                    }
                }
                else
                {
                    var temp = from c in entities.Configuraciones
                               where c.Cedula == cedula
                               select c;
                    List<Configuracione> result = temp.ToList<Configuracione>();

                    if (result.Count > 0)
                    {
                        return result;
                    }
                    else
                    {
                        return result = null;
                    }
                }



            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
