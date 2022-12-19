using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
   public  class AbonosPagar
    {
        SeePOSContext entities;

        public AbonosPagar()
        {
            entities = new SeePOSContext();
        }

        public int CrearAbonoPagar(Abonocpagar Abono)
        {
            try
            {
                entities.Abonocpagars.Add(Abono);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int BorrarAbonoPagar(int id)


        {
            try
            {
                var p = entities.Abonocpagars.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Abonocpagar> ObtenerAbonocpagar(bool porId, string Filtro)
        {
            try
            {

                List<Abonocpagar> result;

                if (porId == true)
                {
                    //buscar por id de la tabla
                    var temp = from c in entities.Abonocpagars
                               where c.IdAbonocpagar == Convert.ToInt64(Filtro)
                               select c;
                    result = temp.ToList<Abonocpagar>();
                }
                else
                {
                    //busca por nombre del proveedor o por numero documento(cheque/tranferencia)
                    var temp = from c in entities.Abonocpagars
                               join p in entities.Proveedores on c.CodProveedor equals p.CodigoProv
                               where p.Nombre.Contains(Filtro) || c.Documento.ToString().Contains(Filtro)
                               orderby c.Fecha descending
                               select c;
                    result = temp.ToList<Abonocpagar>();
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

        public List<Abonocpagar> ObtenerAbonoApartado(int id)
        {
            try
            {
                var temp = from c in entities.Abonocpagars
                           where c.IdAbonocpagar == id
                           select c;
                List<Abonocpagar> result = temp.ToList<Abonocpagar>();

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

        public int AnularAbonoPagar(long id, bool eliminarCheque)
        {
            try
            {
                var p = entities.Abonocpagars.Find(id);
                Abonocpagar viejo = p;                             
                if (viejo != null)
                {
                    viejo.Anulado = true;
                    if (eliminarCheque == true)
                    {
                        //el sistema no permite tener dos veces el mismo cheque
                        //si el usuario quiere volver a digitarlo se pone negativo para que lo vuelva a ingresar
                        viejo.Documento = (viejo.Documento * -1);
                    }
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
