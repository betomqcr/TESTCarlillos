using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
    public class AbonosReintegros
    {
        SeePOSContext entities;

        public AbonosReintegros()
        {
            entities = new SeePOSContext();
        }

        public int CrearAbonoReintegro(Abonoreintegro Abono)
        {
            try
            {
                entities.Abonoreintegros.Add(Abono);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int BorrarAbonoReintegro(int id)


        {
            try
            {
                var p = entities.Abonoreintegros.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Abonoreintegro> ObtenerAbonoApartado()
        {
            try
            {
                var temp = from c in entities.Abonoreintegros

                           select c;
                List<Abonoreintegro> result = temp.ToList<Abonoreintegro>();

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

        public List<Abonoreintegro> ObtenerAbonoApartado(int id)
        {
            try
            {
                var temp = from c in entities.Abonoreintegros
                           where c.IdAbono == id
                           select c;
                List<Abonoreintegro> result = temp.ToList<Abonoreintegro>();

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

        public int EditarAbonoReintegros(int id, Abonoreintegro abono)
        {
            try
            {
                var p = entities.Abonoreintegros.Find(id);
                Abonoreintegro Nuevo = p;                
                Nuevo.Monto = abono.Monto;                
                Nuevo.Fecha = abono.Fecha;               
                Nuevo.IdSucursal = abono.IdSucursal;
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
