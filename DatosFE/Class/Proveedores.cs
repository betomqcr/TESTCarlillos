using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosFE.Models;

namespace DatosFE.Class
{
    class Proveedores
    {
        private FEContext entities;

        public Proveedores()
        {
            entities = new FEContext();
        }

        public int CrearProveedor(Proveedore proveedor) // crear Proveedor apartir de objeto de creacion
        {
            try
            {
                entities.Proveedores.Add(proveedor);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int BorrarProveedor(int id) // borrar Proveedor apartir del id Actividad


        {
            try
            {
                var p = entities.Proveedores.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Proveedore> ObtenerProvedores() //obtener lista Proveedores 
        {
            try
            {
                var temp = from c in entities.Proveedores

                           select c;
                List<Proveedore> result = temp.ToList<Proveedore>();

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
