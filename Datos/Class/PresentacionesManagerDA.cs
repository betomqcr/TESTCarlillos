using Dapper;
using Datos.Connection;
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
    public class PresentacionesManagerDA : IPresentacionesManagerDA
    {
        private readonly SeePOSContext _entities;

        public PresentacionesManagerDA()
        {
            _entities = new SeePOSContext();
        }

        public ResponseGeneric<List<Presentacione>> getPresentaciones()
        {
            try
            {
                List<Presentacione> temp = _entities.Presentaciones.ToList().FindAll(marca => marca.Estado == true);

                return new ResponseGeneric<List<Models.Presentacione>>(temp);
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<List<Models.Presentacione>>(ex);
            }
        }
    }
}
