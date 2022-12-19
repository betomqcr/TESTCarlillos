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
    public class ImpuestosManagerDA : IImpuestosManagerDA
    {
        private readonly SeePOSContext _entities;

        public ImpuestosManagerDA()
        {
            _entities = new SeePOSContext();
        }

        public ResponseGeneric<List<Impuesto>> getImpuestos()
        {
            try
            {
                List<Impuesto> temp = _entities.Impuestos.ToList().FindAll(impuesto => impuesto.Estado == true);

                return new ResponseGeneric<List<Models.Impuesto>>(temp);
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<List<Models.Impuesto>>(ex);
            }
        }
    }
}
