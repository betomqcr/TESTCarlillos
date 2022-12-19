using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosFE.Models;

namespace DatosFE.Class
{
    public class Inventarios
    {
        private FEContext entities;

        public Inventarios()
        {
            entities = new FEContext();
        }

        public int CrearInventarios(Inventario inventario) // crear inventarios apartir de objeto de creacion
        {
            try
            {
                entities.Inventarios.Add(inventario);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int BorrarInventarios(int id) // borrar Inventario apartir del id Actividad


        {
            try
            {
                var p = entities.Inventarios.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Inventario> ObtenerInventario() //obtener lista Inventario
        {
            try
            {
                var temp = from c in entities.Inventarios

                           select c;
                List<Inventario> result = temp.ToList<Inventario>();

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
