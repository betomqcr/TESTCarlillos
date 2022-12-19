using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
    public class ArticulosRelacionados
    {
        SeePOSContext entities;

        public ArticulosRelacionados()
        {
            entities = new SeePOSContext();
        }

        public int CrearArticulosRelacionados(ArticulosRelacionado Articulo)
        {
            try
            {
                entities.ArticulosRelacionados.Add(Articulo);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int BorrarArticulosRelacionados(int id)


        {
            try
            {
                var p = entities.ArticulosRelacionados.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<ArticulosRelacionado> ObtenerArticulosRelacionados()
        {
            try
            {
                var temp = from c in entities.ArticulosRelacionados

                           select c;
                List<ArticulosRelacionado> result = temp.ToList<ArticulosRelacionado>();

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

        public List<ArticulosRelacionado> ObtenerArticulosRelacionados(int id)
        {
            try
            {
                var temp = from c in entities.ArticulosRelacionados
                           where c.Id == id
                           select c;
                List<ArticulosRelacionado> result = temp.ToList<ArticulosRelacionado>();

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

        public int EditarArticulosRelacionados(int id, ArticulosRelacionado Articulo)
        {
            try
            {
                var p = entities.ArticulosRelacionados.Find(id);
                ArticulosRelacionado Nuevo = p;
                Nuevo.Id = Articulo.Id;
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
