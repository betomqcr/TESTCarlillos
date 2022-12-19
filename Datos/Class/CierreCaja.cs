using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
   public class CierreCaja
    {

        SeePOSContext entities;

        public CierreCaja()
        {
            entities = new SeePOSContext();
        }

        public int CrearAreas(Models.Cierrecaja cierrecaja)
        {
            try
            {
                entities.Cierrecajas.Add(cierrecaja);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int AnularCierreCaja(int id)
        {
            try
            {
                var p = entities.Cierrecajas.Find(id);
                Models.Cierrecaja Nuevo = p;                              
                if (Nuevo != null)
                {
                    Nuevo.Anulado = true;
                    entities.Entry(Nuevo).State = EntityState.Modified;
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

        public List<Models.CierreCajaDetMon> ObtenerCierreCajaDetalleMonto(int Id)
        {
            try
            {
                List<Models.CierreCajaDetMon> result;

            
                    var temp = from c in entities.CierreCajaDetMons
                               where c.IdCierreCaja == Id
                               select c;
                    result = temp.ToList<Models.CierreCajaDetMon>();
                

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

        public List<Models.CierreCajaDetTarj> ObtenerCierreCajaDetalleTarjeta(int Id)
        {
            try
            {
                List<Models.CierreCajaDetTarj> result;


                var temp = from c in entities.CierreCajaDetTarjs
                           where c.IdCierreCaja == Id
                           select c;
                result = temp.ToList<Models.CierreCajaDetTarj>();


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

        public List<Models.Cierrecaja> ObtenerCierreCajas(bool porId, string Filtro)
        {
            try
            {
                List<Models.Cierrecaja> result;

                if (porId == false)
                {
                    var temp = from c in entities.Cierrecajas
                               join a in entities.Aperturacajas on c.Apertura equals a.Napertura
                               where a.Nombre.Contains(Filtro)
                               orderby c.Fecha descending
                               select c;
                    result = temp.ToList<Models.Cierrecaja>();
                }
                else
                {
                    var temp = from c in entities.Cierrecajas
                               where c.NumeroCierre == Convert.ToInt32(Filtro)                               
                               select c;
                    result = temp.ToList<Models.Cierrecaja>();
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


    }
}
