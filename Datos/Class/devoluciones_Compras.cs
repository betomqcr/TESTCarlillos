using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
    public class devoluciones_Compras
    {


        private SeePOSContext entities;

        public devoluciones_Compras()
        {
            entities = new SeePOSContext();
        }

        public int Crear(Models.DevolucionesCompra devCompra) 
        {
            try
            {
                entities.DevolucionesCompras.Add(devCompra);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Models.ArticulosComprasDevuelto> BuscarDetalle(long Id)
        {
            try
            {
                List<Models.ArticulosComprasDevuelto> result;
              
                    var temp = from c in entities.ArticulosComprasDevueltos
                               where c.Devolucion == Id
                               select c;
                    result = temp.ToList<Models.ArticulosComprasDevuelto>();
                

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

        public List<Models.DevolucionesCompra> Buscar(bool porNombre, string filtro)  
        {
            try
            {
                List<Models.DevolucionesCompra> result;

                if (porNombre == true)
                {
                    //busca por la descripcion
                    var temp = from c in entities.DevolucionesCompras
                               where c.NombrePro.Contains(filtro) // usar un like                               
                               orderby c.Fecha descending
                               select c;

                    result = temp.ToList<Models.DevolucionesCompra>();
                }
                else
                {
                    //busca por el id de la tabla
                    var temp = from c in entities.DevolucionesCompras
                               where c.Devolucion == Convert.ToInt64(filtro) //convertir el datos de string a long
                               select c;
                    result = temp.ToList<Models.DevolucionesCompra>();
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

        public int Editar(long id, Models.DevolucionesCompra nuevo)
        {
            try
            {
                var p = entities.DevolucionesCompras.Find(id);
                Models.DevolucionesCompra viejo = p;

                if (viejo != null)
                {

                    viejo.IdFacturaCompra = nuevo.IdFacturaCompra;
                    viejo.SaldoAntFact = nuevo.SaldoAntFact;
                    viejo.SubTotalGravado = nuevo.SubTotalGravado;
                    viejo.SubTotalExcento = nuevo.SubTotalExcento;
                    viejo.Descuento = nuevo.Descuento;
                    viejo.Impuesto = nuevo.Impuesto;
                    viejo.Monto = nuevo.Monto;
                    viejo.Fecha = nuevo.Fecha;
                    viejo.Contabilizado = nuevo.Contabilizado;
                    viejo.Asiento = nuevo.Asiento;
                    viejo.Anulado = nuevo.Anulado;
                    viejo.CedulaUsuario = nuevo.CedulaUsuario;
                    viejo.CodMoneda = nuevo.CodMoneda;
                    viejo.NombrePro = nuevo.NombrePro;
                    viejo.ContaInventario = nuevo.ContaInventario;
                    viejo.AsientoInventario = nuevo.AsientoInventario;
                    viejo.FechaEntrada = nuevo.FechaEntrada;

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
                var p = entities.DevolucionesCompras.Find(id);
                Models.DevolucionesCompra viejo = p;

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
