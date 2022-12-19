using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosFE.Models;
using Microsoft.EntityFrameworkCore;

namespace DatosFE.Class
{
  public   class Emisores
    {
        private FEContext entities;

        public Emisores()
        {
            entities = new FEContext();
        }

        public int CrearEmisores(Emisor emisor) // crear emisores s apartir de objeto de creacion
        {
            try
            {
                entities.Emisors.Add(emisor);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int EditarEmisores(int id,Emisor emisor) // crear emisores s apartir de objeto de creacion
        {
            try
            {
                var p = entities.Emisors.Find(id);

                if (p != null)
                {
                    Emisor viejo = p;
                    viejo.TipoIdentificacion = emisor.TipoIdentificacion;
                    viejo.Identificacion = emisor.Identificacion;
                    viejo.Nombre = emisor.Nombre;
                    viejo.Correo = emisor.Correo;
                    viejo.Telefono = emisor.Telefono;
                    viejo.Sucursal = emisor.Sucursal;
                    viejo.Provincia = emisor.Provincia;
                    viejo.Canton = emisor.Canton;
                    viejo.Distrito = emisor.Distrito;
                    viejo.OtrasSeñas = emisor.OtrasSeñas;
                    viejo.Usuario = emisor.Usuario;
                    viejo.Clave = emisor.Clave;
                    viejo.Certificado = emisor.Certificado;
                    viejo.NumeroResolucion = emisor.NumeroResolucion;
                    viejo.FechaResolucion = emisor.FechaResolucion;
                    viejo.IdTipoIdentificacion = emisor.IdTipoIdentificacion;
                    viejo.VenceCertificado = emisor.VenceCertificado;
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

        public int BorrarEmisores(int id) // borrar Emisores apartir del id Actividad


        {
            try
            {
                var p = entities.Emisors.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public Emisor ObtenerEmisores(int Id) //obtener lista Emisores
        {
            try
            {
                var temp = from c in entities.Emisors
                           where c.Id == Id
                           select c;
                List<Emisor> result = temp.ToList<Emisor>();

                if (result.Count > 0)
                {
                    return result.FirstOrDefault();
                }
                else
                {
                    return null;
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
