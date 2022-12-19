using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
    public class ArqueosTarjetas
    {
        SeePOSContext entities;

        public ArqueosTarjetas()
        {
            entities = new SeePOSContext();
        }

        public int CrearArqueosTarjeta(ArqueoTarjetum Arqueo)
        {
            try
            {
                entities.ArqueoTarjeta.Add(Arqueo);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int BorrarArqueosTarjeta(int id)


        {
            try
            {
                var p = entities.ArqueoTarjeta.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<ArqueoTarjetum> ObtenerArqueosTarjetas()
        {
            try
            {
                var temp = from c in entities.ArqueoTarjeta

                           select c;
                List<ArqueoTarjetum> result = temp.ToList<ArqueoTarjetum>();

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

        public List<ArqueoTarjetum> ObtenerArqueosTarjetas(int id)
        {
            try
            {
                var temp = from c in entities.ArqueoTarjeta
                           where c.Id == id
                           select c;
                List<ArqueoTarjetum> result = temp.ToList<ArqueoTarjetum>();

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

        public int EditarArqueosTarjetas(int id, ArqueoTarjetum abono)
        {
            try
            {
                var p = entities.ArqueoTarjeta.Find(id);
                ArqueoTarjetum Nuevo = p;
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
