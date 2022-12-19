using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
   public class AperturasDenominaciones
    {
        SeePOSContext entities;

        public AperturasDenominaciones()
        {
            entities = new SeePOSContext();
        }

        public int CrearAperturaDenominaciones(AperturaDenominacione deno)
        {
            try
            {
                entities.AperturaDenominaciones.Add(deno);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int BorrarAperturaDenominaciones(int id)


        {
            try
            {
                var p = entities.AperturaDenominaciones.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<AperturaDenominacione> ObtenerAperturaDenominaciones()
        {
            try
            {
                var temp = from c in entities.AperturaDenominaciones

                           select c;
                List<AperturaDenominacione> result = temp.ToList<AperturaDenominacione>();

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

        public List<AperturaDenominacione> ObtenerAperturaDenominaciones(int id)
        {
            try
            {
                var temp = from c in entities.AperturaDenominaciones
                           where c.IdApertura == id
                           select c;
                List<AperturaDenominacione> result = temp.ToList<AperturaDenominacione>();

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

        public int EditarAperturaDenominaciones(int id, AperturaDenominacione abono)
        {
            try
            {
                var p = entities.AperturaDenominaciones.Find(id);
                AperturaDenominacione Nuevo = p;                
                Nuevo.Monto = abono.Monto;                
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
