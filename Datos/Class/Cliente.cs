using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;
namespace Datos.Class
{
    public class Cliente
    {

        private SeePOSContext entities;

        public Cliente()
        {
            entities = new SeePOSContext();
        }

        public int Crear(Models.Cliente cliente) // crear carta apartir de objeto de creacion
        {
            try
            {
                entities.Clientes.Add(cliente);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Models.Cliente> Buscar(bool porNombre, string filtro) //obtener lista CartasdeExoneracion 
        {
            try
            {
                List<Models.Cliente> result;

                if (porNombre == true)
                {
                    //busca por la descripcion
                    var temp = from c in entities.Clientes
                               where c.Nombre.Contains(filtro) || c.Cedula.Contains(filtro) // usar un like
                               orderby c.Nombre
                               select c;

                    result = temp.ToList<Models.Cliente>();
                }
                else
                {
                    //busca por el id de la tabla
                    var temp = from c in entities.Clientes
                               where c.Identificacion == Convert.ToInt64(filtro) //convertir el datos de string a long                                   
                               select c;
                    result = temp.ToList<Models.Cliente>();
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

        public int Editar(long id, Models.Cliente cliente)
        {
            try
            {
                var p = entities.Clientes.Find(id);
                Models.Cliente viejo = p;

                if (viejo != null)
                {
                    viejo.Cedula = cliente.Cedula;
                    viejo.Nombre = cliente.Nombre;
                    viejo.Observaciones = cliente.Observaciones;
                    viejo.Telefono01 = cliente.Telefono01;
                    viejo.Telefono02 = cliente.Telefono02;
                    viejo.Fax01 = cliente.Fax01;
                    viejo.Fax02 = cliente.Fax02;
                    viejo.EMail = cliente.EMail;
                    viejo.Abierto = cliente.Abierto;
                    viejo.Direccion = cliente.Direccion;
                    viejo.Impuesto = cliente.Impuesto;
                    viejo.MaxCredito = cliente.MaxCredito;
                    viejo.PlazoCredito = cliente.PlazoCredito;
                    viejo.Descuento = cliente.Descuento;
                    viejo.Empresa = cliente.Empresa;
                    viejo.Tipoprecio = cliente.Tipoprecio;
                    viejo.Sinrestriccion = cliente.Sinrestriccion;
                    viejo.Usuario = cliente.Usuario;
                    viejo.Nombreusuario = cliente.Nombreusuario;
                    viejo.Agente = cliente.Agente;
                    viejo.CodMonedaCredito = cliente.CodMonedaCredito;
                    viejo.ClienteMoroso = cliente.ClienteMoroso;
                    viejo.PrecioSugerido = cliente.PrecioSugerido;
                    viejo.Anulado = cliente.Anulado;
                    viejo.Notificar = cliente.Notificar;
                    viejo.TipoCedula = cliente.TipoCedula;
                    viejo.OrdenCompra = cliente.OrdenCompra;
                    viejo.IdTipoExoneracion = cliente.IdTipoExoneracion;
                    viejo.TipoCliente = cliente.TipoCliente;
                    viejo.CorreoComprobante = cliente.CorreoComprobante;
                    viejo.Actualizado = cliente.Actualizado;
                    viejo.DescuentoEspecial = cliente.DescuentoEspecial;
                    viejo.Relacionados = cliente.Relacionados;
                    viejo.Mag = cliente.Mag;
                    viejo.EnviarRecibo = cliente.EnviarRecibo;
                    viejo.CorreoRecibo = cliente.CorreoRecibo;
                    viejo.UsoInterno = cliente.UsoInterno;
                    viejo.Fallecido = cliente.Fallecido;

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

        public int Borrar(long id) // borrar Actividad apartir del id Actividad
        {
            try
            {
                var p = entities.Clientes.Find(id);
                Models.Cliente Nuevo = p;
                if (Nuevo != null)
                {
                    entities.Remove(p);
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