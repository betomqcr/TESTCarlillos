using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
    public class AbonosApartadosDetalles
    {
        SeePOSContext entities;

        public AbonosApartadosDetalles ()
        {
            entities = new SeePOSContext();
        }

        public int CrearAbonoApartadoDetalle(AbonoApartadosdetalle AbonoDetalle)
        {
            try
            {
                entities.AbonoApartadosdetalles.Add(AbonoDetalle);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int BorrarAbonoApartadoDetalle(int id)


        {
            try
            {
                var p = entities.AbonoApartadosdetalles.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<AbonoApartadosdetalle> ObtenerAbonoApartadoDetalle()
        {
            try
            {
                var temp = from c in entities.AbonoApartadosdetalles

                           select c;
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

        public List<AbonoApartadosdetalle> ObtenerAbonoApartadoDetalle(int id)
        {
            try
            {
                var temp = from c in entities.AbonoApartadosdetalles
                           where c.IdAbonoapartado == id
                           select c;
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

        public int EditarAbonoApartadoDetalle(int id, AbonoApartadosdetalle abono)
        {
            try
            {
                var p = entities.AbonoApartadosdetalles.Find(id);
                AbonoApartadosdetalle Nuevo = p;
                Nuevo.Monto = abono.Monto;
                Nuevo.SaldoAnt = abono.SaldoAnt;
                Nuevo.Intereses = abono.Intereses;
                Nuevo.Abono = abono.Abono;
                Nuevo.AbonoSuMoneda = abono.AbonoSuMoneda;
                Nuevo.Saldo = abono.Saldo;
               // Nuevo.ApartadoNavigation 
               
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
