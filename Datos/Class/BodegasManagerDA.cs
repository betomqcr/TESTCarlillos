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
    public class BodegasManagerDA : IBodegasManagerDA
    {
        private readonly SeePOSContext _entities;

        public BodegasManagerDA()
        {
            _entities = new SeePOSContext();
        }

        public ResponseGeneric<List<Bodega>> getBodegas()
        {
            try
            {
                List<Bodega> temp = _entities.Bodegas.ToList().FindAll(bodega => bodega.Estado == true);

                return new ResponseGeneric<List<Models.Bodega>>(temp);
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<List<Models.Bodega>>(ex);
            }
        }
    }
}
