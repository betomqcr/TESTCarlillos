using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosFE.Models;

namespace DatosFE.Class
{
    public class Vistas
    {
        private FEContext entities;

        public Vistas()
        {
            entities = new FEContext();
        }

        public List<ViewFactura> ObtenerFacturas() //obtener Facturas 
        {
            try
            {
                var temp = from c in entities.ViewFacturas

                           select c;
                List<ViewFactura> result = temp.ToList<ViewFactura>();

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

        public List<ObtenerFacturas43> ObtenerFacturas43(int id) //obtener Facturas 43 
        {
            try
            {
                var temp = from c in entities.ObtenerFacturas43s
                           where c.Id==id
                           select c;
                List<ObtenerFacturas43> result = temp.ToList<ObtenerFacturas43>();

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

        public List<ObtenerDetalleFactura43> ObtenerDetalleFacturas43(int id) //obtener Facturas 43 detalle
        {
            try
            {
                var temp = from c in entities.ObtenerDetalleFactura43s
                           where c.Id == id
                           select c;
                List<ObtenerDetalleFactura43> result = temp.ToList<ObtenerDetalleFactura43>();

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

        public List<ObtenerDevolucion43> ObtenerDevolucionVenta43(int id) //obtener Facturas 43 
        {
            try
            {
                var temp = from c in entities.ObtenerDevolucion43s
                           where c.Devolucion == id
                           select c;
                List<ObtenerDevolucion43> result = temp.ToList<ObtenerDevolucion43>();

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

        public List<ObtenerDetallesDevolucion43> ObtenerDetalleDevolucionVenta43(int id) //obtener Facturas 43 detalle devolucion
        {
            try
            {
                var temp = from c in entities.ObtenerDetallesDevolucion43s
                           where c.Devolucion == id
                           select c;
                List<ObtenerDetallesDevolucion43> result = temp.ToList<ObtenerDetallesDevolucion43>();

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

        public List<GetMensajeXId> GetMensajePorId(int id) //obtener Mensaje por id  
        {
            try
            {
                var temp = from c in entities.GetMensajeXIds
                           where c.Id == id
                           select c;
                List<GetMensajeXId> result = temp.ToList<GetMensajeXId>();

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

        public List<GetMensajeXml43> GetMensajePorId43(int id) //obtener Mensaje por id 43 
        {
            try
            {
                var temp = from c in entities.GetMensajeXml43s
                           where c.Id == id
                           select c;
                List<GetMensajeXml43> result = temp.ToList<GetMensajeXml43>();

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
