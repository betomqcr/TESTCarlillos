using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
    public class AjustesInventariosDetalles
    {
        SeePOSContext entities;

        public AjustesInventariosDetalles()
        {
            entities = new SeePOSContext();
        }

        public int CrearAjusteInventarioDetalles(AjusteInventarioDetalle Abono)
        {
            try
            {
                entities.AjusteInventarioDetalles.Add(Abono);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int BorrarAjustesInventariosDetalles(int id)


        {
            try
            {
                var p = entities.AjusteInventarioDetalles.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<AjusteInventarioDetalle> ObtenerAjustesInventariosDetalles()
        {
            try
            {
                var temp = from c in entities.AjusteInventarioDetalles

                           select c;
                List<AjusteInventarioDetalle> result = temp.ToList<AjusteInventarioDetalle>();

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

        public List<AjusteInventarioDetalle> ObtenerAjustesInventariosDetalles(int id)
        {
            try
            {
                var temp = from c in entities.AjusteInventarioDetalles
                           where c.Consecutivo == id
                           select c;
                List<AjusteInventarioDetalle> result = temp.ToList<AjusteInventarioDetalle>();

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

        public int EditarAjustesInventariosDetalles(int id, AjusteInventarioDetalle abono)
        {
            try
            {
                var p = entities.AjusteInventarioDetalles.Find(id);
                AjusteInventarioDetalle Nuevo = p;
               
               

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
