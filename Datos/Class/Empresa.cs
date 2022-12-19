using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
  public  class Empresa
    {

        private SeePOSContext entities;

        public Empresa()
        {
            entities = new SeePOSContext();
        }
        
        public int Crear(Models.Empresa empresa) // crear carta apartir de objeto de creacion
        {
            try
            {
                entities.Empresas.Add(empresa);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Models.Empresa> Buscar(bool porNombre, string filtro) //obtener lista CartasdeExoneracion 
        {
            try
            {
                List<Models.Empresa> result;

                if (porNombre == true)
                {
                    //busca por la descripcion de la marca
                    var temp = from c in entities.Empresas
                               where c.Empresa1.Contains(filtro)// usar un like
                               select c;

                    result = temp.ToList<Models.Empresa>();
                }
                else
                {
                    //busca por el id de la tabla
                    var temp = from c in entities.Empresas
                               where c.Id == Convert.ToInt32(filtro) //convertir el datos de string a long
                               select c;
                    result = temp.ToList<Models.Empresa>();
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

        public int Editar(long id, Models.Empresa empresa)
        {
            try
            {
                var p = entities.Empresas.Find(id);
                Models.Empresa viejo = p;

                if (viejo != null)
                {
                    viejo.Empresa1 = empresa.Empresa1;
                    viejo.Actual = empresa.Actual;
                    viejo.Cedula = empresa.Cedula;                

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
                var p = entities.Empresas.Find(id);
                Models.Empresa Nuevo = p;
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
