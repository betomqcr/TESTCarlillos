using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
    public class ArticulosComprados
    {
        SeePOSContext entities;

        public ArticulosComprados()
        {
            entities = new SeePOSContext();
        }

        public int CrearArticulosComprados(ArticulosComprado Articulo)
        {
            try
            {
                entities.ArticulosComprados.Add(Articulo);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int BorrarArticulosComprados(int id)


        {
            try
            {
                var p = entities.ArticulosComprados.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<ArticulosComprado> ObtenerArticulosComprados()
        {
            try
            {
                var temp = from c in entities.ArticulosComprados

                           select c;
                List<ArticulosComprado> result = temp.ToList<ArticulosComprado>();

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

        public List<ArticulosComprado> ObtenerArticulosComprados(int id)
        {
            try
            {
                var temp = from c in entities.ArticulosComprados
                           where c.IdArticuloComprados == id
                           select c;
                List<ArticulosComprado> result = temp.ToList<ArticulosComprado>();

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

        public int EditarArticulosComprados(int id, ArticulosComprado Articulo)
        {
            try
            {
                var p = entities.ArticulosComprados.Find(id);
                ArticulosComprado Nuevo = p;
                Nuevo.IdArticuloComprados = Articulo.IdArticuloComprados;
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
