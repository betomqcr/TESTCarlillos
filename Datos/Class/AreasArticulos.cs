using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
    public class AreasArticulos
    {
        SeePOSContext entities;

        public AreasArticulos()
        {
            entities = new SeePOSContext();
        }

        public int CrearAreasArticulos(AreaArticulo area)
        {
            try
            {
                entities.AreaArticulos.Add(area);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int BorrarAreasArticulos(int id)


        {
            try
            {
                var p = entities.AreaArticulos.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<AreaArticulo> ObtenerAreasArticulos()
        {
            try
            {
                var temp = from c in entities.AreaArticulos

                           select c;
                List<AreaArticulo> result = temp.ToList<AreaArticulo>();

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

        public List<AreaArticulo> ObtenerAreasArticulos(int id)
        {
            try
            {
                var temp = from c in entities.AreaArticulos
                           where c.IdAreaArticulo == id
                           select c;
                List<AreaArticulo> result = temp.ToList<AreaArticulo>();

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

        public int EditarAreas(int id, AreaArticulo abono)
        {
            try
            {
                var p = entities.AreaArticulos.Find(id);
                AreaArticulo Nuevo = p;
                Nuevo.IdAreaArticulo = abono.IdAreaArticulo;
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
