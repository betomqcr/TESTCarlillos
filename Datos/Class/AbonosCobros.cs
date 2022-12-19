using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
    public class AbonosCobros
    {
        SeePOSContext entities;

        public AbonosCobros()
        {
            entities = new SeePOSContext();
        }

        public int CrearAbonoCobro(Abonoccobrar Abono)
        {
            try
            {
                entities.Abonoccobrars.Add(Abono);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int BorrarAbonoCobro(int id)


        {
            try
            {
                var p = entities.Abonoccobrars.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public Models.Abonoccobrar Obtener(long id)  //consultar PreVentas
        {
            var p = entities.Abonoccobrars.Find(id);
            Models.Abonoccobrar viejo = p;
            if (viejo != null)
            {
                return viejo;
            }
            else
            {
                return null;
            }
        }

        public List<Models.DetalleAbonoccobrar> ObtenerDetalleAbonoscCobrar(long IdRecibo)
        {
            try
            {
                var temp = from c in entities.DetalleAbonoccobrars
                           where c.IdRecibo == IdRecibo
                           select c;
                List<DetalleAbonoccobrar> result = temp.ToList<DetalleAbonoccobrar>();

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

        public List<Abonoccobrar> ObtenerAbonoCobros()
        {
            try
            {
                var temp = from c in entities.Abonoccobrars

                           select c;
                List<Abonoccobrar> result = temp.ToList<Abonoccobrar>();

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

        public List<Abonoccobrar> ObtenerAbonocCobrar(bool porIdRecibo, string Filtro)// id recibo
        {
            try
            {
                List<Abonoccobrar> result;

                if (porIdRecibo == true)
                {
                    var temp = from c in entities.Abonoccobrars
                               where c.IdRecibo == Convert.ToInt64(Filtro)                               
                               select c;
                    result = temp.ToList<Abonoccobrar>();
                }
                else
                {
                    var temp = from c in entities.Abonoccobrars
                               where c.NombreCliente.Contains(Filtro) || c.NumRecibo.ToString().Contains(Filtro)
                               orderby c.Fecha descending
                               select c;
                    result = temp.ToList<Abonoccobrar>();
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

        public int Anular(long id)
        {
            try
            {
                var p = entities.Abonoccobrars.Find(id);
                Abonoccobrar viejo = p;
               
                if (viejo != null)
                {

                    viejo.Anula = true;
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
