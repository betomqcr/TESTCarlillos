using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
   public class Monedas
    {

        private SeePOSContext entities;

        public Monedas()
        {
            entities = new SeePOSContext();
        }

        public int Crear(Models.Moneda moneda) // crear carta apartir de objeto de creacion
        {
            try
            {
                entities.Monedas.Add(moneda);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Models.Moneda> Buscar(bool porNombre, string filtro) //obtener lista CartasdeExoneracion 
        {
            try
            {
                List<Models.Moneda> result;

                if (porNombre == true)
                {
                    //busca por la descripcion
                    var temp = from c in entities.Monedas
                               where c.MonedaNombre.Contains(filtro)// usar un like
                               orderby c.MonedaNombre
                               select c;

                    result = temp.ToList<Models.Moneda>();
                }
                else
                {
                    //busca por el id de la tabla
                    var temp = from c in entities.Monedas
                               where c.CodMoneda == Convert.ToInt32(filtro) //convertir el datos de string a long
                               select c;
                    result = temp.ToList<Models.Moneda>();
                }

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

        public int Editar(long id, Models.Moneda moneda)
        {
            try
            {
                var p = entities.Monedas.Find(id);
                Models.Moneda viejo = p;

                if (viejo != null)
                {
                    viejo.MonedaNombre = moneda.MonedaNombre;
                    viejo.ValorCompra = moneda.ValorCompra;
                    viejo.ValorVenta = moneda.ValorVenta;
                    viejo.Simbolo = moneda.Simbolo;

                    entities.Entry(viejo).State = EntityState.Modified;

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

        public int Borrar(long id) // borrar Actividad apartir del id Actividad
                     {
            try
            {
                var p = entities.Monedas.Find(id);
                Models.Moneda Nuevo = p;
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
