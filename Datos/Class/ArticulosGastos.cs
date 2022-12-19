using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
    public class ArticulosGastos
    {
        SeePOSContext entities;

        public ArticulosGastos()
        {
            entities = new SeePOSContext();
        }

        public int CrearArticulosGastos(ArticulosGasto Articulo)
        {
            try
            {
                entities.ArticulosGastos.Add(Articulo);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int BorrarArticulosGastos(int id)


        {
            try
            {
                var p = entities.ArticulosGastos.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<ArticulosGasto> ObtenerArticulosGastos()
        {
            try
            {
                var temp = from c in entities.ArticulosGastos

                           select c;
                List<ArticulosGasto> result = temp.ToList<ArticulosGasto>();

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

        public List<ArticulosGasto> ObtenerArticulosGastos(int id)
        {
            try
            {
                var temp = from c in entities.ArticulosGastos
                           where c.IdArticuloComprados == id
                           select c;
                List<ArticulosGasto> result = temp.ToList<ArticulosGasto>();

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

        public int EditarArticulosGastos(int id, ArticulosGasto Articulo)
        {
            try
            {
                var p = entities.ArticulosGastos.Find(id);
                ArticulosGasto Nuevo = p;
                Nuevo.IdArticuloComprados = Articulo.IdArticuloComprados;
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
