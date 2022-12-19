using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
    public class devoluciones_ventas
    {

        private SeePOSContext entities;

        public devoluciones_ventas()
        {
            entities = new SeePOSContext();
        }

        public int Crear(Models.DevolucionesVenta devVenta) 
        {
            try
            {                
                entities.DevolucionesVentas.Add(devVenta);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Models.ArticulosVentasDevuelto> BuscarDetalle(long Id)
        {
            try
            {
                List<Models.ArticulosVentasDevuelto> result;
                    var temp = from c in entities.ArticulosVentasDevueltos
                               where c.Devolucion == Id
                               select c;
                    result = temp.ToList<Models.ArticulosVentasDevuelto>();
                

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

        public List<Models.DevolucionesVenta> Buscar(bool porNombre, string filtro)  
        {
            try
            {
                List<Models.DevolucionesVenta> result;

                if (porNombre == true)
                {
                    //busca por la descripcion
                    var temp = from c in entities.DevolucionesVentas
                               join v in entities.Ventas on c.IdFactura equals v.Id
                               where v.NombreCliente.Contains(filtro) // usar un like                               
                               orderby c.Fecha descending
                               select c;

                    result = temp.ToList<Models.DevolucionesVenta>();
                }
                else
                {
                    //busca por el id de la tabla
                    var temp = from c in entities.DevolucionesVentas
                               where c.Devolucion == Convert.ToInt64(filtro) //convertir el datos de string a long
                               select c;
                    result = temp.ToList<Models.DevolucionesVenta>();
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

        public int Editar(long id, Models.DevolucionesVenta nuevo)
        {
            try
            {
                var p = entities.DevolucionesVentas.Find(id);
                Models.DevolucionesVenta viejo = p;

                if (viejo != null)
                {

                    viejo.IdFactura = nuevo.IdFactura;
                    viejo.SaldoAntFact = nuevo.SaldoAntFact;
                    viejo.SubTotalGravado = nuevo.SubTotalGravado;
                    viejo.SubTotalExcento = nuevo.SubTotalExcento;
                    viejo.Descuento = nuevo.Descuento;
                    viejo.Impuesto = nuevo.Impuesto;
                    viejo.Monto = nuevo.Monto;
                    viejo.Fecha = nuevo.Fecha;
                    viejo.Contabilizado = nuevo.Contabilizado;
                    viejo.NumeroAsiento = nuevo.NumeroAsiento;
                    viejo.Anulado = nuevo.Anulado;
                    viejo.CedulaUsuario = nuevo.CedulaUsuario;
                    viejo.CodMoneda = nuevo.CodMoneda;
                    viejo.Transporte = nuevo.Transporte;
                    viejo.ContabilizadoCosto = nuevo.ContabilizadoCosto;
                    viejo.NumeroAsientoCosto = nuevo.NumeroAsientoCosto;
                    viejo.Caja = nuevo.Caja;
                    viejo.Consecutivo = nuevo.Consecutivo;
                    viejo.Enviadodgt = nuevo.Enviadodgt;
                    viejo.Estadodgt = nuevo.Estadodgt;
                    viejo.Consecutivodgt = nuevo.Consecutivodgt;
                    viejo.Clavedgt = nuevo.Clavedgt;
                    viejo.MontoDevolucion = nuevo.MontoDevolucion;
                    viejo.NumApertura = nuevo.NumApertura;
                    viejo.UsuarioRecibio = nuevo.UsuarioRecibio;
                    viejo.NotasDevolucion = nuevo.NotasDevolucion;

                    //falta el detalle

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

        public int Anular(long id) 


        {
            try
            {
                var p = entities.DevolucionesVentas.Find(id);
                Models.DevolucionesVenta viejo = p;

                if (viejo != null)
                {
                    viejo.Anulado = true;
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

    }
}
