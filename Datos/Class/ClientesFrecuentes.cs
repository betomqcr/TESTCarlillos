using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;
namespace Datos.Class
{
  public  class ClientesFrecuentes
    {

        private SeePOSContext entities;

        public ClientesFrecuentes()
        {
            entities = new SeePOSContext();
        }

        public int Crear(Models.ClientesFrecuente cliente) // crear carta apartir de objeto de creacion
        {
            try
            {
                entities.ClientesFrecuentes.Add(cliente);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Models.ClientesFrecuente> Buscar(bool porNombre, string filtro) //obtener lista CartasdeExoneracion 
        {
            try
            {
                List<Models.ClientesFrecuente> result;

                if (porNombre == true)
                {
                    //busca por la descripcion
                    var temp = from c in entities.ClientesFrecuentes
                               where c.Nombre.Contains(filtro) || c.Cedula.Contains(filtro) // usar un like
                               orderby c.Nombre
                               select c;

                    result = temp.ToList<Models.ClientesFrecuente>();
                }
                else
                {
                    //busca por el id de la tabla
                    var temp = from c in entities.ClientesFrecuentes
                               where c.Identificacion == Convert.ToInt64(filtro) //convertir el datos de string a long                                   
                               select c;
                    result = temp.ToList<Models.ClientesFrecuente>();
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

        public int Editar(long id, Models.ClientesFrecuente clientefrecuente)
        {
            try
            {
                var p = entities.ClientesFrecuentes.Find(id);
                Models.ClientesFrecuente viejo = p;

                if (viejo != null)
                {
                    viejo.Cedula = clientefrecuente.Cedula;
                    viejo.Nombre = clientefrecuente.Nombre;
                    viejo.Observaciones = clientefrecuente.Observaciones;
                    viejo.Telefono01 = clientefrecuente.Telefono01;
                    viejo.Telefono02 = clientefrecuente.Telefono02;
                    viejo.Fax01 = clientefrecuente.Fax01;
                    viejo.Fax02 = clientefrecuente.Fax02;
                    viejo.EMail = clientefrecuente.EMail;
                    viejo.Direccion = clientefrecuente.Direccion;
                    viejo.Tipoprecio = clientefrecuente.Tipoprecio;
                    viejo.Usuario = clientefrecuente.Usuario;
                    viejo.Nombreusuario = clientefrecuente.Nombreusuario;
                    viejo.Anulado = clientefrecuente.Anulado;
                    viejo.Esempresa = clientefrecuente.Esempresa;
                    viejo.TipoCliente = clientefrecuente.TipoCliente;

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
                var p = entities.ClientesFrecuentes.Find(id);
                Models.ClientesFrecuente Nuevo = p;
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
