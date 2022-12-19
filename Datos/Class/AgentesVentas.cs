using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
    public class AgentesVentas
    {
        SeePOSContext entities;

        public AgentesVentas()
        {
            entities = new SeePOSContext();
        }

        public int CrearAgenteVentas(AgenteVenta agente)
        {
            try
            {
                entities.AgenteVentas.Add(agente);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int BorrarAgenteVenta(long id)


        {
            try
            {
                var p = entities.AgenteVentas.Find(id);
                AgenteVenta borrar = p;
                if (borrar != null)
                {
                    entities.Remove(borrar);
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

        public List<AgenteVenta> ObtenerAgenteVentas(string nombre)
        {
            try
            {
                var temp = from c in entities.AgenteVentas
                          where c.Nombre.Contains(nombre) //filtrar por concidencia del nombre.
                           select c;
                List<AgenteVenta> result = temp.ToList<AgenteVenta>();

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

        public List<AgenteVenta> ObtenerAgenteVentas(int id)
        {
            try
            {
                var temp = from c in entities.AgenteVentas
                           where c.Id == id
                           select c;
                List<AgenteVenta> result = temp.ToList<AgenteVenta>();

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

        public int EditarAgenteVentas(long id, AgenteVenta agente)
        {
            try
            {
                var p = entities.AgenteVentas.Find(id);
                AgenteVenta viejo = p;                                            
                if (viejo != null)
                {
                    viejo.IdSucursal = agente.IdSucursal;
                    viejo.Nombre = agente.Nombre;
                    viejo.Telefono = agente.Telefono;
                    viejo.Direccion = agente.Direccion;
                    viejo.Correo = agente.Correo;
                    viejo.TipoPrecio = agente.TipoPrecio;
                    viejo.Anulado = agente.Anulado;
                    viejo.IdSucursal = agente.IdSucursal;
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
