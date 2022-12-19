using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
    public class AbonosApartados
    {
        SeePOSContext entities;

        public AbonosApartados()
        {
            entities = new SeePOSContext();
        }

        public int CrearAbonoApartado(AbonoApartado Abono)
        {
            try
            {
                entities.AbonoApartados.Add(Abono);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int BorrarAbonoApartado(int id) 


        {
            try
            {
                var p = entities.AbonoApartados.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<AbonoApartadosdetalle> AbonosporApartado(long IdApartado)  
        {
            try
            {
                var temp = from a in entities.AbonoApartados
                           join ad in entities.AbonoApartadosdetalles on a.IdAbonoapartado equals ad.IdAbonoapartado
                           where ad.Apartado == IdApartado && a.Anula == false
                           select ad;
                List<AbonoApartadosdetalle> result = temp.ToList<AbonoApartadosdetalle>();

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

        public List<AbonoApartado> ObtenerAbonoApartado(int id)  
        {
            try
            {
                var temp = from c in entities.AbonoApartados
                           where c.IdAbonoapartado == id
                           select c;
                List<AbonoApartado> result = temp.ToList<AbonoApartado>();

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
