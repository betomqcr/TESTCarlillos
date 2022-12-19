using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
    public class ArticulosCompradosDevueltos
    {
        SeePOSContext entities;

        public ArticulosCompradosDevueltos()
        {
            entities = new SeePOSContext();
        }

        public int CrearArticulosCompradosDevueltos(ArticulosComprasDevuelto Articulo)
        {
            try
            {
                entities.ArticulosComprasDevueltos.Add(Articulo);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int BorrarArticulosCompradosDevueltos(int id)


        {
            try
            {
                var p = entities.ArticulosComprasDevueltos.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<ArticulosComprasDevuelto> ObtenerArticulosCompradosDevueltos()
        {
            try
            {
                var temp = from c in entities.ArticulosComprasDevueltos

                           select c;
                List<ArticulosComprasDevuelto> result = temp.ToList<ArticulosComprasDevuelto>();

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

        public List<ArticulosComprasDevuelto> ObtenerArticulosCompradosDevueltos(int id)
        {
            try
            {
                var temp = from c in entities.ArticulosComprasDevueltos
                           where c.Consecutivo == id
                           select c;
                List<ArticulosComprasDevuelto> result = temp.ToList<ArticulosComprasDevuelto>();

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

        public int EditarArticulosComprados(int id, ArticulosComprasDevuelto Articulo)
        {
            try
            {
                var p = entities.ArticulosComprasDevueltos.Find(id);
                ArticulosComprasDevuelto Nuevo = p;
                Nuevo.Consecutivo  = Articulo.Consecutivo;
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
