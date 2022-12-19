using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
   public  class AreasEncargados
    {
        SeePOSContext entities;

        public AreasEncargados()
        {
            entities = new SeePOSContext();
        }

        public int CrearAreasEncargado(AreaEncargado area)
        {
            try
            {
                entities.AreaEncargados.Add(area);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int BorrarAreasEncargado(int id)


        {
            try
            {
                var p = entities.AreaEncargados.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<AreaEncargado> ObtenerAreasEncargados()
        {
            try
            {
                var temp = from c in entities.AreaEncargados

                           select c;
                List<AreaEncargado> result = temp.ToList<AreaEncargado>();

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

        public List<AreaEncargado> ObtenerAreasEncargados(int id)
        {
            try
            {
                var temp = from c in entities.AreaEncargados
                           where c.IdArea == id
                           select c;
                List<AreaEncargado> result = temp.ToList<AreaEncargado>();

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

        public int EditarAreasEncargado(int id, AreaEncargado abono)
        {
            try
            {
                var p = entities.AreaEncargados.Find(id);
                AreaEncargado Nuevo = p;
                Nuevo.IdArea = abono.IdArea;
                //Nuevo.AbonoApartadosdetalles = abono.AbonoApartadosdetalle;

                entities.Entry(Nuevo).State = EntityState.Modified;

                return entities.SaveChanges();


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
