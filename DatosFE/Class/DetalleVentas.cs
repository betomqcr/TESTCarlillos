using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosFE.Models;

namespace DatosFE.Class
{
    class DetalleVentas
    {
        private FEContext entities;

        public DetalleVentas()
        {
            entities = new FEContext();
        }

        public int CrearDetalleVentas(VentasDetalle Venta) // crear Detalle ventas apartir de objeto de creacion
        {
            try
            {
                entities.VentasDetalles.Add(Venta);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int BorrarDetalleVenta(int id) // borrar Detalle Venta apartir del id Actividad


        {
            try
            {
                var p = entities.VentasDetalles.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<VentasDetalle> ObtenerDetalleVentas() //obtener lista Ventas detalle 
        {
            try
            {
                var temp = from c in entities.VentasDetalles

                           select c;
                List<VentasDetalle> result = temp.ToList<VentasDetalle>();

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
