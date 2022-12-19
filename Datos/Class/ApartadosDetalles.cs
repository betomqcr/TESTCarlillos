using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
   public  class ApartadosDetalles
    {
        SeePOSContext entities;

        public ApartadosDetalles()
        {
            entities = new SeePOSContext();
        }

        public int CrearApartadosDetalles(ApartadoDetalle apartado)
        {
            try
            {
                entities.ApartadoDetalles.Add(apartado);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int BorrarApartadosDetalles(int id)


        {
            try
            {
                var p = entities.ApartadoDetalles.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<ApartadoDetalle> ObtenerApartadosDetalles()
        {
            try
            {
                var temp = from c in entities.ApartadoDetalles

                           select c;
                List<ApartadoDetalle> result = temp.ToList<ApartadoDetalle>();

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

        public List<ApartadoDetalle> ObtenerApartadosDetalles(int id)
        {
            try
            {
                var temp = from c in entities.ApartadoDetalles
                           where c.IdApartado == id
                           select c;
                List<ApartadoDetalle> result = temp.ToList<ApartadoDetalle>();

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

        public int EditarApartadosDetalles(int id, ApartadoDetalle abono)
        {
            try
            {
                var p = entities.ApartadoDetalles.Find(id);
                ApartadoDetalle Nuevo = p;
                
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
