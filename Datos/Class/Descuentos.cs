using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
    public class Descuentos
    {


        private SeePOSContext entities;

        public Descuentos()
        {
            entities = new SeePOSContext();
        }

        public int Crear(Models.Descuento descuentos) 
        {
            try
            {
                entities.Descuentos.Add(descuentos);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Models.Descuento> ObtenerporId(decimal id)
        {
            try
            {
                List<Models.Descuento> result;
               
                var temp = from c in entities.Descuentos
                           where c.IdDescuento == id 
                           select c;
                result = temp.ToList<Models.Descuento>();


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

        public int Editar(decimal id, Models.Descuento nuevo)
        {
            try
            {
                var p = entities.Descuentos.Find(id);
                Models.Descuento viejo = p;

                if (viejo != null)
                {

                    viejo.IdProveedor = nuevo.IdProveedor;
                    viejo.Desde = nuevo.Desde;
                    viejo.Hasta = nuevo.Hasta;
                    viejo.Descuento1 = nuevo.Descuento1;
                    viejo.Confirmado = nuevo.Confirmado;
                    viejo.ContactoConfirmo = nuevo.ContactoConfirmo;

                    entities.Entry(viejo).State = EntityState.Modified;

                    return entities.SaveChanges();
                }
                else
                {
                    return 0;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int Borrar(decimal id)


        {
            try
            {
                var p = entities.Descuentos.Find(id);               
                Models.Descuento Nuevo = p;
                if (Nuevo != null)
                {
                    entities.Remove(p);
                    return entities.SaveChanges();
                }
                else
                {
                    return 0;// no se encotro el registro solicitado.
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


    }
}
