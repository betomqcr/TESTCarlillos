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
    public class MonedaManagerDA : IMonedasManagerDA
    {
        private readonly SeePOSContext _entities;

        public MonedaManagerDA()
        {
            _entities = new SeePOSContext();
        }

        public ResponseGeneric<List<Moneda>> getMonedas()
        {
            try
            {
                List<Moneda> temp = _entities.Monedas.ToList().FindAll(moneda => moneda.Estado == true);

                return new ResponseGeneric<List<Models.Moneda>>(temp);
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<List<Models.Moneda>>(ex);
            }
        }
    }
}
