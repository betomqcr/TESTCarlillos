using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
    public class AjustesPagar
    {
        SeePOSContext entities;

        public AjustesPagar()
        {
            entities = new SeePOSContext();
        }

        public int CrearAjustesPagar(Ajustescpagar pagar)
        {
            try
            {
                entities.Ajustescpagars.Add(pagar);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int BorrarAjustesPagar(int id)


        {
            try
            {
                var p = entities.Ajustescpagars.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<DetalleAjustescPagar> ObtenerDetalles(long Id)
        {
            try
            {

                List<DetalleAjustescPagar> result;

                    var temp = from c in entities.DetalleAjustescPagars
                               where c.IdAjustecPagar == Id
                               select c;
                    result = temp.ToList<DetalleAjustescPagar>();



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

        public List<Ajustescpagar> ObtenerAjustesPagar(bool porId, string Filtro)
        {
            try
            {

                List<Ajustescpagar> result;

                if (porId == true)
                {
                    var temp = from c in entities.Ajustescpagars
                               where c.IdAjuste == Convert.ToInt64(Filtro)
                               select c;
                    result = temp.ToList<Ajustescpagar>();
                }
                else
                {
                    var temp = from c in entities.Ajustescpagars
                               where c.NombreProveedor.Contains(Filtro) || c.AjusteNo.ToString().Contains(Filtro)
                               orderby c.Fecha descending
                               select c;
                    result = temp.ToList<Ajustescpagar>();
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



        public List<DetalleAjustescPagar> ObtenerAjustesPagar(long id)
        {
            try
            {
                var temp = from c in entities.DetalleAjustescPagars
                           where c.IdAjustecPagar == id
                           select c;
                List<DetalleAjustescPagar> result = temp.ToList<DetalleAjustescPagar>();

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

        public int AnularAjustesPagar(long id)
        {
            try
            {          
                var p = entities.Ajustescpagars.Find(id);
                Models.Ajustescpagar viejo = p;
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
