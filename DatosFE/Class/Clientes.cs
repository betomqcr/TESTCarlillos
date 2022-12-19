using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosFE.Models;

namespace DatosFE.Class
{
    public class Clientes
    {
        private FEContext entities;

        public Clientes()
        {
            entities = new FEContext();
        }

        public int CrearCliente(Cliente cliente) // crear clientes apartir de objeto de creacion
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

        public int BorrarCliente(int id) // borrar cliente apartir del id Client


        {
            try
            {
                var p = entities.Clientes.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Cliente> ObtenerClientes() //obtener lista Articulos comprado
        {
            try
            {
                var temp = from c in entities.Clientes

                           select c;
                List<Cliente> result = temp.ToList<Cliente>();

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
    }
}
