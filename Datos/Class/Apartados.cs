using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
    public class Apartados
    {
        SeePOSContext entities;

        public Apartados()
        {
            entities = new SeePOSContext();
        }

        public int CrearApartados(Apartado ajuste)
        {
            try
            {
                entities.Apartados.Add(ajuste);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Models.ViewApartadosActivo> Buscar(bool porNombre, string filtro) //obtener lista CartasdeExoneracion 
        {
            try
            {
                List<Models.ViewApartadosActivo> result;

                if (porNombre == true)
                {
                    //busca por la descripcion
                    var temp = from c in entities.ViewApartadosActivos
                               where c.Cliente.Contains(filtro) // usar un like
                               orderby c.Fecha descending
                               select c;

                    result = temp.ToList<Models.ViewApartadosActivo>();
                }
                else
                {
                    //busca por el id de la tabla
                    var temp = from c in entities.ViewApartadosActivos
                               where c.Apartado == Convert.ToInt64(filtro) //convertir el datos de string a long
                               select c;
                    result = temp.ToList<Models.ViewApartadosActivo>();
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

        public int BorrarApartados(int id)


        {
            try
            {
                var p = entities.Apartados.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<ApartadoDetalle> ObtenerDetalleApartados(long IdApartado)
        {
            try
            {
                var temp = from c in entities.ApartadoDetalles
                           where c.IdApartado == IdApartado
                           select c;
                List<ApartadoDetalle> result = temp.ToList<ApartadoDetalle>();

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

        public List<Apartado> ObtenerApartados()
        {
            try
            {
                var temp = from c in entities.Apartados

                           select c;
                List<Apartado> result = temp.ToList<Apartado>();

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

        public List<Apartado> ObtenerApartados(int id)
        {
            try
            {
                var temp = from c in entities.Apartados
                           where c.IdApartado == id
                           select c;
                List<Apartado> result = temp.ToList<Apartado>();

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

        public int EditarApartados(int id, Apartado abono)
        {
            try
            {
                var p = entities.Apartados.Find(id);
                Apartado Nuevo = p;                
                Nuevo.Monto = abono.Monto;                
                Nuevo.Fecha = abono.Fecha;
                Nuevo.Observaciones = abono.Observaciones;                
                Nuevo.CodMoneda = abono.CodMoneda;                
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
