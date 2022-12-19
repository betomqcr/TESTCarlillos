using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
  public  class Proveedores
    {

        private SeePOSContext entities;

        public Proveedores()
        {
            entities = new SeePOSContext();
        }

        public int Crear(Models.Proveedore proveedor) // crear carta apartir de objeto de creacion
        {
            try
            {
                entities.Proveedores.Add(proveedor);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Models.Proveedore> Buscar(bool porNombre, string filtro) //obtener lista CartasdeExoneracion 
        {
            try
            {
                List<Models.Proveedore> result;

                if (porNombre == true)
                {
                    //busca por la descripcion
                    var temp = from c in entities.Proveedores
                               where c.Nombre.Contains(filtro) || c.Cedula.Contains(filtro)// usar un like
                               orderby c.Nombre
                               select c;

                    result = temp.ToList<Models.Proveedore>();
                }
                else
                {
                    //busca por el id de la tabla
                    var temp = from c in entities.Proveedores
                               where c.CodigoProv == Convert.ToInt32(filtro) //convertir el datos de string a long
                               select c;
                    result = temp.ToList<Models.Proveedore>();
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

        public int Editar(int id, Models.Proveedore proveedor)
        {
            try
            {
                var p = entities.Proveedores.Find(id);
                Models.Proveedore viejo = p;

                if (viejo != null)
                {
                    viejo.Cedula    = proveedor.Cedula;
                    viejo.Nombre = proveedor.Nombre;
                    viejo.Contacto = proveedor.Contacto;
                    viejo.TelefonoCont = proveedor.TelefonoCont;
                    viejo.Observaciones = proveedor.Observaciones;
                    viejo.Telefono1 = proveedor.Telefono1;
                    viejo.Telefono2 = proveedor.Telefono2;
                    viejo.Fax1 = proveedor.Fax1;
                    viejo.Fax2 = proveedor.Fax2;
                    viejo.Email = proveedor.Email;
                    viejo.Direccion = proveedor.Direccion;
                    viejo.MontoCredito = proveedor.MontoCredito;
                    viejo.Plazo = proveedor.Plazo;
                    viejo.CostoTotal = proveedor.CostoTotal;
                    viejo.ImpIncluido = proveedor.ImpIncluido;
                    viejo.PedidosMes = proveedor.PedidosMes;
                    viejo.UtilidadInventario = proveedor.UtilidadInventario;
                    viejo.UtilidadFija = proveedor.UtilidadFija;
                    viejo.CuentaContable = proveedor.CuentaContable;
                    viejo.DescripcionCuentaContable = proveedor.DescripcionCuentaContable;
                    viejo.Actualizado = proveedor.Actualizado;
                    viejo.Inhabilitado = proveedor.Inhabilitado;
                    viejo.Fec = proveedor.Fec;
                    viejo.TipoProveedor = proveedor.TipoProveedor;
                    viejo.IdProvincia = proveedor.IdProvincia;
                    viejo.IdCanton = proveedor.IdCanton ;
                    viejo.IdDistrito = proveedor.IdDistrito;
                    viejo.OtrasSenas = proveedor.OtrasSenas;
                    viejo.CodigoActividad = proveedor.CodigoActividad;
                    viejo.CorreoElectronico = proveedor.CorreoElectronico;
                    viejo.Serie = proveedor.Serie;
                    viejo.Bloqueado = proveedor.Bloqueado;
                    

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

        public int Borrar(int id) // borrar Actividad apartir del id Actividad


        {
            try
            {
                var p = entities.Proveedores.Find(id);
                Models.Proveedore Nuevo = p;
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
