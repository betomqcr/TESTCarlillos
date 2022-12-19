using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
 public   class CajasCantidad
    {
        SeePOSContext entities;

        public CajasCantidad()
        {
            entities = new SeePOSContext();
        }


        public List<Models.CajasCantidad> ObtenerCajasCantidad()
        {
            try
            {
                List<Models.CajasCantidad> result;


                    var temp = from c in entities.CajasCantidads
                               where c.NumApertura == 0
                               select c;

                    result = temp.ToList<Models.CajasCantidad>();
              

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
