using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosFE.Models;

namespace DatosFE.Class
{
   public  class Compras
    {
        private FEContext entities;

        public Compras()
        {
            entities = new FEContext();
        }

        public int CrearCompra(Compra compra) // crear Compra apartir de objeto de creacion
        {
            try
            {
                entities.Compras.Add(compra);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int BorrarCompra(int id) // borrar Compra apartir del id Compra


        {
            try
            {
                var p = entities.Compras.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Compra> ObtenerCompras() //obtener lista Compras 
        {
            try
            {
                var temp = from c in entities.Compras

                           select c;
                List<Compra> result = temp.ToList<Compra>();

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
