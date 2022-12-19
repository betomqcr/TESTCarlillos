using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
    public class AperturasTotalesTopes
    {
        SeePOSContext entities;

        public AperturasTotalesTopes()
        {
            entities = new SeePOSContext();
        }

        public int CrearAperturasTotalesTopes(AperturaTotalTope tope)
        {
            try
            {
                entities.AperturaTotalTopes.Add(tope);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int BorrarAperturasTotalesTopes(int id)


        {
            try
            {
                var p = entities.AperturaTotalTopes.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<AperturaTotalTope> ObtenerAperturasTotalesTopes()
        {
            try
            {
                var temp = from c in entities.AperturaTotalTopes

                           select c;
                List<AperturaTotalTope> result = temp.ToList<AperturaTotalTope>();

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

        public List<AperturaTotalTope> ObtenerAperturasTotalesTopes(int id)
        {
            try
            {
                var temp = from c in entities.AperturaTotalTopes
                           where c.IdTotalTope == id
                           select c;
                List<AperturaTotalTope> result = temp.ToList<AperturaTotalTope>();

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

        public int EditarAperturasTotalesTopes(int id, AperturaTotalTope abono)
        {
            try
            {
                var p = entities.AperturaTotalTopes.Find(id);
                AperturaTotalTope Nuevo = p;               
                Nuevo.CodMoneda = abono.CodMoneda;
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
