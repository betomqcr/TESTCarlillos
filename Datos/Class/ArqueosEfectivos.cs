using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
   public  class ArqueosEfectivos
    {
        SeePOSContext entities;

        public ArqueosEfectivos()
        {
            entities = new SeePOSContext();
        }

        public int CrearArqueosEfectivos(ArqueoEfectivo Arqueo)
        {
            try
            {
                entities.ArqueoEfectivos.Add(Arqueo);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int BorrarArqueosEfectivos(int id)


        {
            try
            {
                var p = entities.ArqueoEfectivos.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<ArqueoEfectivo> ObtenerArqueosEfectivos()
        {
            try
            {
                var temp = from c in entities.ArqueoEfectivos

                           select c;
                List<ArqueoEfectivo> result = temp.ToList<ArqueoEfectivo>();

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

        public List<ArqueoEfectivo> ObtenerArqueosEfectivos(int id)
        {
            try
            {
                var temp = from c in entities.ArqueoEfectivos
                           where c.Id == id
                           select c;
                List<ArqueoEfectivo> result = temp.ToList<ArqueoEfectivo>();

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

        public int EditarArqueosEfectivos(int id, ArqueoEfectivo abono)
        {
            try
            {
                var p = entities.ArqueoEfectivos.Find(id);
                ArqueoEfectivo Nuevo = p;
                Nuevo.Id = abono.Id;
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
