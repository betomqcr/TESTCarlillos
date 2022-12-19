using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosFE.Models;

namespace DatosFE.Class
{
    public class Actividades
    {
        private FEContext entities;

        public Actividades()
        {
            entities = new FEContext();
        }

        public int CrearActividad(ActividadEmpresa Actividad) // crear Actividad apartir de objeto de creacion
        {
            try
            {
                entities.ActividadEmpresas.Add(Actividad);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int BorrarActividad(int id) // borrar Actividad apartir del id Actividad


        {
            try
            {
                var p = entities.ActividadEmpresas.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<ActividadEmpresa> ObtenerActividades() //obtener lista actividades 
        {
            try
            {
                var temp = from c in entities.ActividadEmpresas
                           
                           select c;
                List<ActividadEmpresa> result = temp.ToList<ActividadEmpresa>();

                if (result.Count>0)
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
