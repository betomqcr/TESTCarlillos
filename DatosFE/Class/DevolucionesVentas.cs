using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosFE.Models;
using Microsoft.EntityFrameworkCore;

namespace DatosFE.Class
{
  public  class DevolucionesVentas
    {
        private FEContext entities;

        public DevolucionesVentas()
        {
            entities = new FEContext();
        }

        public int CrearDevolucionesVentas(DevolucionesVenta articulo) // crear Devoluciones Ventas apartir de objeto de creacion
        {
            try
            {
                entities.DevolucionesVentas.Add(articulo);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int BorrarDevolucionesVenta(long id) // borrar Devoluciones Ventas apartir del id Actividad


        {
            try
            {
                var p = entities.DevolucionesVentas.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<DevolucionesVenta> ObtenerDevolucionesVenta() //obtener lista Articulos devueltos
        {
            try
            {
                var temp = from c in entities.DevolucionesVentas

                           select c;
                List<DevolucionesVenta> result = temp.ToList<DevolucionesVenta>();

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

        public string ObtenerClaveDevolucion(long id) // Retorna la clave de devolucion
        {
            try
            {
                var p = entities.DevolucionesVentas.Find(id);
                DevolucionesVenta viejo = p;

                if (viejo != null)
                {
                    string clave = viejo.Clavedgt;
                    return clave;
                }
                else
                {
                    return "No existe Devolucion Venta";
                }



            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string ObtenerNumeroConsecutivoDevolucion(long id) // Retorna la Numero Consecutivo de venta
        {
            try
            {
                var p = entities.DevolucionesVentas.Find(id);
                DevolucionesVenta viejo = p;

                if (viejo != null)
                {
                    string consecutivo = viejo.Consecutivodgt;
                    return consecutivo;
                }
                else
                {
                    return "No existe devolucion de venta";
                }



            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int EditarEstadoDevolucionVenta(long id, string estado, string xmlClave = "", string xmlConsecutivo = "") // editar estado de Hacienda devolucion de venta
        {
            try
            {
                var p = entities.DevolucionesVentas.Find(id);
                DevolucionesVenta viejo = p;
                viejo.Estadodgt = estado;

                if (xmlClave != "" && xmlConsecutivo != ""){
                    viejo.Clavedgt = xmlClave;
                    viejo.Consecutivodgt = xmlConsecutivo;
                }


                if(estado == "aceptado")
                {
                    viejo.Enviadodgt = true;
                }

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
