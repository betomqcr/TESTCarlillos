using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;

namespace Datos.Class
{
    public class Sucursales
    {
        SeePOSContext entities;

        public Sucursales()
        {
            entities = new SeePOSContext();
        }

        public int CrearSucursales(Sucursale sucursal) 
        {
            try
            {
                entities.Sucursales.Add(sucursal);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public int BorrarSucursales(long id) 


        {
            try
            {
                var p = entities.Sucursales.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Proveedore> ObtenerSucursales()  
        {
            try
            {
                List<Models.Proveedore> result;

                
                    //busca por la descripcion
                    var temp = from c in entities.Proveedores
                                   // usar un like
                               select c;

                    result = temp.ToList<Models.Proveedore>();
                
                
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
