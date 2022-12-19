using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosFE.Models;
using Microsoft.EntityFrameworkCore;

namespace DatosFE.Class
{
   public class MensajeRecepcionHacienda
    {
        private FEContext entities;

        public MensajeRecepcionHacienda()
        {
            entities = new FEContext();
        }

        public int CrearMensajeReceptor(MensajeReceptor mensaje) // crear Mensaje Receptor apartir de objeto de creacion
        {
            try
            {
                entities.MensajeReceptors.Add(mensaje);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int BorrarMensajeReceptor(int id) // borrar Mensaje Receptor apartir del id Actividad


        {
            try
            {
                var p = entities.MensajeReceptors.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<MensajeReceptor> ObtenerMensajeReceptor(bool porestado, string estados, bool porfecha, DateTime desde, DateTime hasta) //obtener lista actividades 
        {
            try
            {

                var temp = from c in entities.MensajeReceptors
                           select c;

                string[] estadosHacienda = estados.ToLower().Split(',');

             

                if (porfecha == true && porestado == true && estadosHacienda.Count() == 1 && estadosHacienda[0].Equals("aceptado") )
                {
                    temp = from c in entities.MensajeReceptors
                           where c.FechaEmisionDoc >= desde && c.FechaEmisionDoc <= hasta && c.Estado.ToLower().Equals("aceptado")
                           select c;
                }else if (porfecha == true && porestado == true && estadosHacienda.Count() == 1 && estadosHacienda[0].Equals("rechazado"))
                {
                    temp = from c in entities.MensajeReceptors
                           where c.FechaEmisionDoc >= desde && c.FechaEmisionDoc <= hasta && c.Estado.ToLower().Equals("rechazado")
                           select c;
                
            }else if (porfecha == true && porestado == true && estadosHacienda.Count() > 1 )
            {
                temp = from c in entities.MensajeReceptors
                       where c.FechaEmisionDoc >= desde && c.FechaEmisionDoc <= hasta 
                       select c;
            }
            else if (porfecha == false && porestado == false) 
                {
                    temp = from c in entities.MensajeReceptors
                           select c;
                }
                else if (porfecha == false && porestado == true)
                {
                     temp = from c in entities.MensajeReceptors
                               where c.Estado.Equals(estados)
                               select c;
                }
                else if (porfecha == false && porestado == false) 
                {
                    temp = from c in entities.MensajeReceptors
                           select c;
                }
                else if (porfecha == true && porestado == false)
                {
                     temp = from c in entities.MensajeReceptors 
                               where c.FechaEmisionDoc >= desde && c.FechaEmisionDoc <= hasta select c;
                }


                    List<MensajeReceptor> result = temp.ToList<MensajeReceptor>();

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

        public int EditarEstadoYConcecutivoMensajeReceptor(int id, string estado, string consecutivo) // editar estado de Hacienda mensaje receptor
        {
            try
            {
                var p = entities.MensajeReceptors.Find(id);
                MensajeReceptor viejo = p;
                viejo.Estado = estado;
                viejo.Consecutivo = consecutivo;
                
                entities.Entry(viejo).State = EntityState.Modified;

                return entities.SaveChanges();


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int EditarEstadoMensajeReceptor(int id, string estado) // editar estado de Hacienda mensaje receptor
        {
            try
            {
                var p = entities.MensajeReceptors.Find(id);
                MensajeReceptor viejo = p;
                viejo.Estado = estado;
                
                entities.Entry(viejo).State = EntityState.Modified;

                return entities.SaveChanges();


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
