using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
    public class ArticulosProveedores
    {
        SeePOSContext entities;

        public ArticulosProveedores()
        {
            entities = new SeePOSContext();
        }

        public int CrearArticulosProveedores(ArticulosProveedor Articulo)
        {
            try
            {
                entities.ArticulosProveedors.Add(Articulo);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int BorrarArticulosProveedores(int id)


        {
            try
            {
                var p = entities.ArticulosProveedors.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<ArticulosProveedor> ObtenerArticulosProveedores()
        {
            try
            {
                var temp = from c in entities.ArticulosProveedors

                           select c;
                List<ArticulosProveedor> result = temp.ToList<ArticulosProveedor>();

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

        public List<ArticulosProveedor> ObtenerArticulosProveedores(int id)
        {
            try
            {
                var temp = from c in entities.ArticulosProveedors
                           where c.Id == id
                           select c;
                List<ArticulosProveedor> result = temp.ToList<ArticulosProveedor>();

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

        public int EditarArticulosProveedores(int id, ArticulosProveedor Articulo)
        {
            try
            {
                var p = entities.ArticulosProveedors.Find(id);
                ArticulosProveedor Nuevo = p;
                Nuevo.Id = Articulo.Id;
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
