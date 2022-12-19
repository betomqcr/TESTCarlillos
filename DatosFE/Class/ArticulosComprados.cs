using DatosFE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DatosFE.Class
{
    public class ArticulosComprados
    {
        private FEContext entities;

        public ArticulosComprados()
        {
            entities = new FEContext();
        }

        public int CrearArticulosComprados(ArticulosComprado articulo) // crear Articulos comprado apartir de objeto de creacion
        {
            try
            {
                entities.ArticulosComprados.Add(articulo);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int BorrarArticulosComprados(int id) // borrar Articulos comprado apartir del id Actividad


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

        public List<ArticulosComprado> ObtenerArticulosComprados() //obtener lista Articulos comprado
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


    }
}
