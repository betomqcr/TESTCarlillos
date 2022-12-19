using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
  public  class Bodegas
    {


        private SeePOSContext entities;

        public Bodegas()
        {
            entities = new SeePOSContext();
        }

        public int Crear(Models.Bodega bodega) // crear carta apartir de objeto de creacion
        {
            try
            {
                entities.Bodegas.Add(bodega);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Models.Bodega> Buscar(bool porNombre, string filtro) //obtener lista CartasdeExoneracion 
        {
            try
            {
                List<Models.Bodega> result;

                if (porNombre == true)
                {
                    //busca por la descripcion
                    var temp = from c in entities.Bodegas
                               where c.NombreBodega.Contains(filtro) // usar un like
                               orderby c.NombreBodega
                               select c;

                    result = temp.ToList<Models.Bodega>();
                }
                else
                {
                    //busca por el id de la tabla
                    var temp = from c in entities.Bodegas
                               where c.IdBodega == Convert.ToInt32(filtro) //convertir el datos de string a long
                               select c;
                    result = temp.ToList<Models.Bodega>();
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

        public int Editar(int id, Models.Bodega proveedor)
        {
            try
            {
                var p = entities.Bodegas.Find(id);
                Models.Bodega viejo = p;

                if (viejo != null)
                {
                    viejo.NombreBodega = proveedor.NombreBodega;
                    viejo.Observaciones = proveedor.Observaciones;
                    viejo.Bloqueada = proveedor.Bloqueada;                  

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

        public int Borrar(int id) // borrar Actividad apartir del id Actividad


        {
            try
            {
                var p = entities.Bodegas.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
}
