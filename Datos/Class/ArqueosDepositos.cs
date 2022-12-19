using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
    public class ArqueosDepositos
    {
        SeePOSContext entities;

        public ArqueosDepositos()
        {
            entities = new SeePOSContext();
        }

        public int CrearArqueosDepositos(ArqueoDeposito Arqueo)
        {
            try
            {
                entities.ArqueoDepositos.Add(Arqueo);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int BorrarArqueosDepositos(int id)


        {
            try
            {
                var p = entities.ArqueoDepositos.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<ArqueoDeposito> ObtenerArqueosDepositos()
        {
            try
            {
                var temp = from c in entities.ArqueoDepositos

                           select c;
                List<ArqueoDeposito> result = temp.ToList<ArqueoDeposito>();

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

        public List<ArqueoDeposito> ObtenerArqueosDepositos(int id)
        {
            try
            {
                var temp = from c in entities.ArqueoDepositos
                           where c.Id == id
                           select c;
                List<ArqueoDeposito> result = temp.ToList<ArqueoDeposito>();

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

        public int EditarArqueosCajas(int id, ArqueoDeposito abono)
        {
            try
            {
                var p = entities.ArqueoDepositos.Find(id);
                ArqueoDeposito Nuevo = p;
                Nuevo.Id = abono.Id;
                //Nuevo.AbonoApartadosdetalles = abono.AbonoApartadosdetalle;

                entities.Entry(Nuevo).State = EntityState.Modified;

                return entities.SaveChanges();


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
