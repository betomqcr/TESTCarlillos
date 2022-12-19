using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosFE.Models;


namespace DatosFE.Class
{
    public class VentasDevueltas
    {
        private FEContext entities;

        public VentasDevueltas()
        {
            entities = new FEContext();
        }

        public int CrearVentasDevueltas(ArticulosVentasDevuelto articulo) // crear Articulos duvueltos apartir de objeto de creacion
        {
            try
            {
                entities.ArticulosVentasDevueltos.Add(articulo);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int BorrarVentasDevueltas(int id) // borrar Articulos devueltos apartir del id Actividad


        {
            try
            {
                var p = entities.ArticulosVentasDevueltos.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<ArticulosVentasDevuelto> ObtenerVentasDevueltas() //obtener lista Articulos devueltos
        {
            try
            {
                var temp = from c in entities.ArticulosVentasDevueltos

                           select c;
                List<ArticulosVentasDevuelto> result = temp.ToList<ArticulosVentasDevuelto>();

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
