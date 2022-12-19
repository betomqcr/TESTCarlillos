using Datos.DTOs;
using Datos.Helpers;
using Datos.Interfaces;
using Datos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Class
{
    public class TipoExoneracionManager : ITipoExoneracionManagerDA
    {

        private readonly SeePOSContext _entities;

        public TipoExoneracionManager()
        {
            _entities = new SeePOSContext();
        }

        public ResponseGeneric<List<Models.TipoExoneracion>> getTipoExoneracion()
        {
            try
            {
                List<Models.TipoExoneracion> temp = _entities.TipoExoneracions.ToList();
                           
                return new ResponseGeneric<List<Models.TipoExoneracion>>(temp);
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<List<Models.TipoExoneracion>>(ex);
            }
        }
    }
}
